using FastFoodSimulator.Services;

namespace FastFoodSimulator
{
    public partial class Form1 : Form
    {
        int _customerArrivelTime;
        int _orderFullfilmentTime;

        ManagerService _managerService;
        public Form1()
        {
            InitializeComponent();

            _managerService = new ManagerService();
        }

        private void ShowWarningMessage(string message, TextBox input)
        { 
            input.ForeColor = Color.Red;
            input.Focus();
            MessageBox.Show(message);
        }

        private string ValidateTimeInterval(int time)
        {
            if(time < 0)
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

        private bool ValidateInput(TextBox input)
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

        private void StartSimulation()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            _managerService.StartManage(token, _customerArrivelTime, _orderFullfilmentTime);

            ManagerService._orderTakerService.OnCustomersChange += (count) =>
            {
                customersNumberOTSTextBox.Invoke(() =>
                {
                    customersNumberOTSTextBox.Text = count.ToString();
                });
            };

            ManagerService._orderTakerService.OnOrderTake += (orderNumber) =>
            {
                orderNumberOTSTextBox.Invoke(() =>
                {
                    orderNumberOTSTextBox.Text = orderNumber.ToString();
                });
            };

            ManagerService._kitchenService.OnPrepareOrder += (orderNumber) =>
            {
                pOrderNumberKSTextBox.Invoke(() =>
                {
                    pOrderNumberKSTextBox.Text = orderNumber.ToString();
                });
            };


        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool isCustomerTimeValid = ValidateInput(customerArrivelTextBox);
            bool isOrderPreparationTimeValid = ValidateInput(orderPreparationTimeTextBox);

           if(isCustomerTimeValid && isOrderPreparationTimeValid)
            {
                _customerArrivelTime = Convert.ToInt32(customerArrivelTextBox.Text);
                _orderFullfilmentTime = Convert.ToInt32(orderPreparationTimeTextBox.Text);

                customerArrivelTextBox.ForeColor = Color.Black;
                orderPreparationTimeTextBox.ForeColor = Color.Black;

                StartSimulation();
            }
        }
    }
}