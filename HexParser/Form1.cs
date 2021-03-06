﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace HexParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
                fileTextBox.Text = ofd.FileName;
        }

        private void parseButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fileTextBox.Text))
                MessageBox.Show("ERROR: File doesn't exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.WaitCursor;
            parseButton.Text = "Parsing...";
            parseButton.Enabled = false;
            parseButton.Update();
            
            using (FileStream fs = File.OpenRead(fileTextBox.Text))
            {
                codeTextBox.Text = "{";

                uint parser = 0;
                while (fs.Position < fs.Length)
                {
                    if (parser > 0xF)
                    {
                        codeTextBox.Text += "\n";
                        parser = 0;
                    }

                    byte b = (byte)fs.ReadByte();

                    codeTextBox.Text += " 0x" + (b <= 0xF ? "0" : "") + string.Format("{0:X},", b);

                    if (!oneLineCheckBox.Checked)
                        parser++;
                }
                codeTextBox.Text = codeTextBox.Text.Remove(codeTextBox.Text.Length - 1, 1);
                codeTextBox.Text += " }";
            }

            Cursor.Current = Cursors.Default;
            parseButton.Text = "Parse!";
            parseButton.Enabled = true;
            clipboardButton.Enabled = true;
        }

        private void clipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(codeTextBox.Text, TextDataFormat.Text);
        }

        private void gitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/Pokes303");
        }
    }
}
