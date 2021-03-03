﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoppingListWindowsFormsApp
{
    public partial class EnterNameForm : Form
    {
        User user;
        public EnterNameForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            enterNameTextBox.Focus();
            string name = enterNameTextBox.Text.ToUpper();

            if (!IsValidName(name))
            {
                return;
            }
            user.Name = name;
            Close();
        }

        private bool IsValidName(string name)
        {
            if (name.Length > 30 || name.Length == 0)
            {
                enterNameTextBox.Text = "";
                MessageBox.Show("Имя не должно быть пустым  и привышать 30 знаков.");
                DialogResult = DialogResult.None;
                return false;
            }

            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] < 'А' && name[i] != 'Ё') || name[i] > 'Я')
                {
                    enterNameTextBox.Text = "";
                    MessageBox.Show("Имя должно состоять только из букв русского алфавита!");
                    DialogResult = DialogResult.None;
                    return false;
                }
            }
            return true;
        }

        private void EnterNameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
