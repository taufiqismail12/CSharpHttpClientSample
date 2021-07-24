using HttpClientSample.API;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HttpClientSample.DataModel;

namespace HttpClientSample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void BtnGetData_ClickAsync(object sender, EventArgs e)
        {
            string ID = TxtID.Text;
            if (!string.IsNullOrEmpty(ID))
            {
                Post post = await PostAPI.GetSinglePost(ID);
                postBindingSource.Add(post);
            }
            else
            {
                MessageBox.Show("Please input ID");
            }
        }

        private async void BtnGetAllData_Click(object sender, EventArgs e)
        {
            postBindingSource.DataSource = new List<Post>();
            postBindingSource.DataSource = await PostAPI.GetAllPost();

        }
    }
}
