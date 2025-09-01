using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.Forms
{
    internal static class ButtonAnimationHelper
    {
        // Aktif animasyonları takip etmek için
        private static readonly ConcurrentDictionary<Button, CancellationTokenSource> _activeAnimations
            = new ConcurrentDictionary<Button, CancellationTokenSource>();

        // Varsayılan renkler - Modern ve şık
        private static readonly Color DefaultHoverColor = Color.FromArgb(74, 144, 226);   // Güzel mavi
        private static readonly Color DefaultNormalColor = SystemColors.Control;

        /// <summary>
        /// Mouse enter animasyonu - daha yumuşak ve hızlı
        /// </summary>
        public static async Task ButtonMouseEnterAsync(Button button,
            Color? targetColor = null,
            int durationMs = 200,
            int steps = 20)
        {
            if (button == null || button.IsDisposed) return;

            Color target = targetColor ?? DefaultHoverColor;
            await AnimateColorTransition(button, target, durationMs, steps);
        }

        /// <summary>
        /// Mouse leave animasyonu - daha yumuşak ve hızlı
        /// </summary>
        public static async Task ButtonMouseLeaveAsync(Button button,
            Color? targetColor = null,
            int durationMs = 200,
            int steps = 20)
        {
            if (button == null || button.IsDisposed) return;

            Color target = targetColor ?? DefaultNormalColor;
            await AnimateColorTransition(button, target, durationMs, steps);
        }

        /// <summary>
        /// Ana animasyon methodu - cancellation token ile
        /// </summary>
        private static async Task AnimateColorTransition(Button button, Color targetColor, int durationMs, int steps)
        {
            // Önceki animasyonu iptal et
            if (_activeAnimations.TryRemove(button, out var oldCts))
            {
                oldCts?.Cancel();
                oldCts?.Dispose();
            }

            // Yeni cancellation token oluştur
            var cts = new CancellationTokenSource();
            _activeAnimations[button] = cts;

            try
            {
                Color startColor = button.BackColor;
                int stepDelay = Math.Max(1, durationMs / steps);

                for (int i = 0; i <= steps; i++)
                {
                    // Cancellation kontrolü
                    if (cts.Token.IsCancellationRequested) return;
                    if (button.IsDisposed) return;

                    float progress = (float)i / steps;

                    // Easing function (ease-out effect için)
                    progress = 1f - (float)Math.Pow(1 - progress, 3);

                    Color currentColor = InterpolateColor(startColor, targetColor, progress);

                    // UI thread'de çalıştır
                    if (button.InvokeRequired)
                    {
                        button.Invoke(new Action(() => button.BackColor = currentColor));
                    }
                    else
                    {
                        button.BackColor = currentColor;
                    }

                    if (i < steps) // Son adımda delay yapma
                    {
                        await Task.Delay(stepDelay, cts.Token);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Animasyon iptal edildi, normal durum
            }
            catch (ObjectDisposedException)
            {
                // Button dispose edilmiş
            }
            finally
            {
                // Cleanup
                _activeAnimations.TryRemove(button, out _);
                cts?.Dispose();
            }
        }

        /// <summary>
        /// İki renk arasında interpolasyon yapar
        /// </summary>
        private static Color InterpolateColor(Color start, Color end, float progress)
        {
            progress = Math.Max(0f, Math.Min(1f, progress)); // 0-1 arasında sınırla

            int r = (int)(start.R + (end.R - start.R) * progress);
            int g = (int)(start.G + (end.G - start.G) * progress);
            int b = (int)(start.B + (end.B - start.B) * progress);
            int a = (int)(start.A + (end.A - start.A) * progress);

            return Color.FromArgb(a, r, g, b);
        }

        /// <summary>
        /// Button için kolay setup methodu
        /// </summary>
        public static void SetupButtonAnimation(Button button,
            Color? hoverColor = null,
            Color? normalColor = null,
            int animationDuration = 200)
        {
            Color hover = hoverColor ?? DefaultHoverColor;
            Color normal = normalColor ?? DefaultNormalColor;

            // Başlangıç rengini ayarla
            button.BackColor = normal;

            // Event handler'ları ekle
            button.MouseEnter += async (s, e) => await ButtonMouseEnterAsync(button, hover, animationDuration);
            button.MouseLeave += async (s, e) => await ButtonMouseLeaveAsync(button, normal, animationDuration);
        }

        /// <summary>
        /// Tüm aktif animasyonları temizle (form kapatılırken kullanılabilir)
        /// </summary>
        public static void ClearAllAnimations()
        {
            foreach (var kvp in _activeAnimations)
            {
                kvp.Value?.Cancel();
                kvp.Value?.Dispose();
            }
            _activeAnimations.Clear();
        }
    }
}
