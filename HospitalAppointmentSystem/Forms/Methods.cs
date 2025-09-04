using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem.Forms
{
    internal class Methods
    {
        public static async void ButtonMouseLeave(Button button) 
        {
            for (int i = 0; i <= 10; i++)
            {
                button.BackColor = Color.FromArgb(
                    255,
                    button.BackColor.R + (int)((240 - button.BackColor.R) * 0.1),
                    button.BackColor.G + (int)((240 - button.BackColor.G) * 0.1),
                    button.BackColor.B + (int)((240 - button.BackColor.B) * 0.1)
                );
                await Task.Delay(15);
            }
        }
        public static async void ButtonMouseEnter(Button button) 
        {
            for (int i = 0; i <= 10; i++)
            {
                button.BackColor = Color.FromArgb(
                    255,
                    button.BackColor.R + (int)((255 - button.BackColor.R) * 0.1),
                    button.BackColor.G + (int)((200 - button.BackColor.G) * 0.1),
                    button.BackColor.B
                );
                await Task.Delay(15);
            }
        }

        public static async void ImageMouseEnter(PictureBox imageBox) 
        {
            for(int i = 0; i <= 10; i++) 
            {
                imageBox.Location = new Point(
                    imageBox.Location.X + 1,
                    imageBox.Location.Y 
                );
                await Task.Delay(10);
            }
        }
        public static async void ImageMouseLeave(PictureBox imageBox)
        {
            for (int i = 0; i <= 10; i++)
            {
                imageBox.Location = new Point(
                    imageBox.Location.X - 1,
                    imageBox.Location.Y
                );
                await Task.Delay(10);
            }
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int[] lastIndex = new int[256];
            for (int i = 0; i < 256; i++) lastIndex[i] = -1;

            int maxLen = 0;
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char ch = s[right];
                if (lastIndex[ch] >= left)
                {
                    left = lastIndex[ch] + 1;
                }

                lastIndex[ch] = right;
                int windowLen = right - left + 1;
                if (windowLen > maxLen)
                {
                    maxLen = windowLen;
                }
            }

            return maxLen;
        }
        public static void ShowFormAsPanel(Form formToShow, Form parentForm, ref Form currentForm)
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                parentForm.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }
            currentForm = formToShow;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            parentForm.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();
            parentForm.Text = formToShow.Text;
        }
    }
}
