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
        private static readonly ConcurrentDictionary<Button, CancellationTokenSource> _activeAnimations
            = new ConcurrentDictionary<Button, CancellationTokenSource>();

        private static readonly Color DefaultHoverColor = Color.FromArgb(74, 144, 226);   
        private static readonly Color DefaultNormalColor = SystemColors.Control;
        public static async Task ButtonMouseEnterAsync(Button button,
            Color? targetColor = null,
            int durationMs = 200,
            int steps = 20)
        {
            if (button == null || button.IsDisposed) return;

            Color target = targetColor ?? DefaultHoverColor;
            await AnimateColorTransition(button, target, durationMs, steps);
        }
        public static async Task ButtonMouseLeaveAsync(Button button,
            Color? targetColor = null,
            int durationMs = 200,
            int steps = 20)
        {
            if (button == null || button.IsDisposed) return;

            Color target = targetColor ?? DefaultNormalColor;
            await AnimateColorTransition(button, target, durationMs, steps);
        }
        private static async Task AnimateColorTransition(Button button, Color targetColor, int durationMs, int steps)
        {
            if (_activeAnimations.TryRemove(button, out var oldCts))
            {
                oldCts?.Cancel();
                oldCts?.Dispose();
            }

            var cts = new CancellationTokenSource();
            _activeAnimations[button] = cts;

            try
            {
                Color startColor = button.BackColor;
                int stepDelay = Math.Max(1, durationMs / steps);

                for (int i = 0; i <= steps; i++)
                {
                    if (cts.Token.IsCancellationRequested) return;
                    if (button.IsDisposed) return;

                    float progress = (float)i / steps;

                    progress = 1f - (float)Math.Pow(1 - progress, 3);

                    Color currentColor = InterpolateColor(startColor, targetColor, progress);

                    if (button.InvokeRequired)
                    {
                        button.Invoke(new Action(() => button.BackColor = currentColor));
                    }
                    else
                    {
                        button.BackColor = currentColor;
                    }

                    if (i < steps) 
                    {
                        await Task.Delay(stepDelay, cts.Token);
                    }
                }
            }
            catch (OperationCanceledException)
            {
            }
            catch (ObjectDisposedException)
            {
            }
            finally
            {
                _activeAnimations.TryRemove(button, out _);
                cts?.Dispose();
            }
        }
        private static Color InterpolateColor(Color start, Color end, float progress)
        {
            progress = Math.Max(0f, Math.Min(1f, progress));

            int r = (int)(start.R + (end.R - start.R) * progress);
            int g = (int)(start.G + (end.G - start.G) * progress);
            int b = (int)(start.B + (end.B - start.B) * progress);
            int a = (int)(start.A + (end.A - start.A) * progress);

            return Color.FromArgb(a, r, g, b);
        }

        public static void SetupButtonAnimation(Button button,
            Color? hoverColor = null,
            Color? normalColor = null,
            int animationDuration = 200)
        {
            Color hover = hoverColor ?? DefaultHoverColor;
            Color normal = normalColor ?? DefaultNormalColor;

            button.BackColor = normal;

            button.MouseEnter += async (s, e) => await ButtonMouseEnterAsync(button, hover, animationDuration);
            button.MouseLeave += async (s, e) => await ButtonMouseLeaveAsync(button, normal, animationDuration);
        }

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
