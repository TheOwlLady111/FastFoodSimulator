namespace FastFoodSimulator.Validation
{
    public static class Validation
    {
        public static bool ValidateInput(TextBox input)
        {
            if (input.Text == String.Empty)
            {
                ShowWarningMessage("Field is required.", input);

                return false;
            }
            else
            {
                int time = Convert.ToInt32(input.Text);
                var message = ValidateTimeInterval(time);

                if (message != String.Empty)
                {
                    ShowWarningMessage(message, input);

                    return false;
                }
            }

            return true;
        }

        private static void ShowWarningMessage(string message, TextBox input)
        {
            input.ForeColor = Color.Red;
            input.Focus();

            MessageBox.Show(message);
        }

        private static string ValidateTimeInterval(int time)
        {
            if (time < 0)
            {
                return "Interval can't be less than 0.";
            }
            else
            {
                if (time > 10)
                {
                    return "Interval can't be greater than 10.";
                }
            }

            return "";
        }
    }
}
