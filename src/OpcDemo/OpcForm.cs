using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua.Client;

namespace OpcUaSample
{
    public partial class OpcForm : Form
    {
        private readonly Session _currentSession;

        public OpcForm(Session session)
        {
            InitializeComponent();
            _currentSession = session;
        }

        private void BtnOpcRead_Click(object sender, EventArgs e)
        {
            var nodeId = GetNodeId();
            TbNodeReadValue.Text = _currentSession.ReadValue(nodeId).ToString();
        }

        private string GetNodeId()
        {
            return TbNodeId.Text;
        }

        private void BtnChangeValue_Click(object sender, EventArgs e)
        {
            var nodeId = GetNodeId();

            var methodId = TbMethodId.Text;
            var singleParam = Int16.Parse(GetParameters().Item1);
            var floatParam = float.Parse(GetParameters().Item2);

            var res = _currentSession.Call(nodeId, methodId, singleParam, floatParam);
            TbCallValueResult.Text = res.FirstOrDefault()?.ToString();
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            var nodeId = GetNodeId();

            var methodId = TbMethodId.Text;
            var boolParam = bool.Parse(GetParameters().Item2);
            var intParam = Int16.Parse(GetParameters().Item1);

            var res = _currentSession.Call(nodeId, methodId, intParam,boolParam);
            TbCallValueResult.Text = res.FirstOrDefault()?.ToString();
        }

        private (string, string) GetParameters()
        {
            return (TbParamFir.Text,TbParamSecond.Text);
        }
    }             
}
