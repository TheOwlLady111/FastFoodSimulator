using FastFoodSimulator.Services;

namespace FastFoodSimulator
{
    public partial class Form1 : Form
    {
        private int _customerArrivelTime;
        private int _orderFullfilmentTime;

        private ManagerService _managerService;
        private CancellationTokenSource _cancellationTokenSource;
        private CancellationToken _token;

        public Form1()
        {
            InitializeComponent();

            _managerService = new ManagerService();
            _cancellationTokenSource = new CancellationTokenSource();
        }

        private void StartSimulation()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _token = _cancellationTokenSource.Token;

            _managerService.StartManage(_token, _customerArrivelTime, _orderFullfilmentTime);

            ManagerService._orderTakerService.OnCustomersChange += (customers) =>
            {
                customersNumberOTSTextBox.Invoke(() =>
                {
                    customersNumberOTSTextBox.Text = customers.Count.ToString();
                });

                orderTakerListBox.Invoke(() =>
                {
                    orderTakerListBox.DataSource = customers.ToList();
                    orderTakerListBox.DisplayMember = "Id";
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

            ManagerService._kitchenService.OnChangeOrder += (b) =>
            {
                wOrdersNumberKSTextBox.Invoke(() =>
                {
                    wOrdersNumberKSTextBox.Text = b.Count.ToString();
                });

                wOrdersKSListBox.Invoke(() =>
                {
                    wOrdersKSListBox.DataSource = b.ToList();
                    wOrdersKSListBox.DisplayMember = "Id";
                });
            };

            ManagerService._serverService.OnPreparedOrderTake += (number) =>
            {
                orderSSTextBox.Invoke(() =>
                {
                    orderSSTextBox.Text = number.ToString();
                });
            };

            ManagerService._serverService.OnServedCustomersChange += (customers) =>
            {
                customersNumberSSTextBox.Invoke(() =>
                {
                    customersNumberSSTextBox.Text = customers.Count.ToString();
                });

                serverListBox.Invoke(() =>
                {
                    serverListBox.DataSource = customers.ToList();
                    serverListBox.DisplayMember = "Id";
                });
            };
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool isCustomerTimeValid = Validation.Validation.ValidateInput(customerArrivelTextBox);
            bool isOrderPreparationTimeValid = Validation.Validation.ValidateInput(orderPreparationTimeTextBox);

            if (isCustomerTimeValid && isOrderPreparationTimeValid)
            {
                _customerArrivelTime = Convert.ToInt32(customerArrivelTextBox.Text);
                _orderFullfilmentTime = Convert.ToInt32(orderPreparationTimeTextBox.Text);

                customerArrivelTextBox.ForeColor = Color.Black;
                orderPreparationTimeTextBox.ForeColor = Color.Black;

                StartSimulation();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
            //_managerService.ResetManager();

            //wOrdersNumberKSTextBox.Text = String.Empty;
            //customersNumberOTSTextBox.Text = String.Empty;
            //orderTakerListBox.DataSource = null;
            //orderNumberOTSTextBox.Text = String.Empty;
            //pOrderNumberKSTextBox.Text = String.Empty;
            //wOrdersKSListBox.DataSource = null;
            //orderSSTextBox.Text = String.Empty;
            //customersNumberSSTextBox.Text = String.Empty;
            //serverListBox.DataSource = null;

        }
    }
}