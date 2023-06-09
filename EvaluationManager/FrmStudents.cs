﻿using EvaluationManager.Models;
using EvaluationManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager
{
    public partial class FrmStudents : Form
    {
        public FrmStudents()
        {
            InitializeComponent();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            ShowStudents();

        }

        private void ShowStudents()
        {
            List<Student> students = StudentRepository.GetStudents();
            dgvStudents.DataSource = students;
        }

    }
}
