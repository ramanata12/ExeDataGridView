﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridView
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DarkGreen;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.DarkRed;

            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
