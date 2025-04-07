﻿using SMS.App.Views.IViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App
{
    public partial class ProgramView : Form, IProgramView
    {
        public ProgramView()
        {
            InitializeComponent();

            buttonCreate.Click += delegate
            {
                CreateEvent?.Invoke(this, EventArgs.Empty);
            };
            buttonRead.Click += delegate
            {
                ReadEvent?.Invoke(this, EventArgs.Empty);
            };
            buttonUpdate.Click += delegate
            {
                UpdateEvent?.Invoke(this, EventArgs.Empty);
            };
            buttonDelete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
            };

        }

        public event EventHandler CreateEvent;
        public event EventHandler ReadEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;

        public int ProgramId { get => Convert.ToInt16(textBoxId.Text); set => textBoxId.Text = value.ToString(); }
        public string ProgramName { get => textBoxProgramName.Text.Trim(); set => textBoxProgramName.Text = value; }
        public string Description { get => textBoxDescription.Text.Trim(); set => textBoxDescription.Text = value; }

        public void GetProgramList(BindingSource bindingSource)
        {
            dataGridViewProgramList.DataSource = bindingSource;
        }
    }
}
