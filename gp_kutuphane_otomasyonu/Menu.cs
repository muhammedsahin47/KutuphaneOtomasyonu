﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp_kutuphane_otomasyonu
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        //Menü formundan sonraki tüm açılacak olan formalar önceki forma geçiş olmayacak şekilde "ShowDialog()" olarak açılır böylece aynı anda 2 işlem yapılmaması önlenir
        private void btn_ogrenci_islemleri_Click(object sender, EventArgs e)// Öğrenci işlemleri formuna geçiş
        {
            frm_OgrenciIslemleri KA = new frm_OgrenciIslemleri();
            KA.ShowDialog();
        }

        private void btn_kitap_islemleri_Click(object sender, EventArgs e)// Kitap işlemleri formuna geçiş
        {
            frm_KitapIslemleri KI = new frm_KitapIslemleri();
            KI.ShowDialog();
        }

        private void btn_kitap_verme_Click(object sender, EventArgs e)// Emanet(kiralama)  işlemleri formuna geçiş
        {
            frm_KitapVermeİslemi KVI = new frm_KitapVermeİslemi();
            KVI.Show();
        }

        private void btn_kitap_takibi_Click(object sender, EventArgs e)// Kitap Takibi formuna geçiş
        {
            frm_KitapTakibi KT = new frm_KitapTakibi();
            KT.ShowDialog();
        }

        private void lbl_ogr_Click(object sender, EventArgs e)
        {
            frm_OgrenciIslemleri KA = new frm_OgrenciIslemleri();
            KA.ShowDialog();
        }

        private void lbl_kitapislemleri_Click(object sender, EventArgs e)
        {
            frm_OgrenciIslemleri KA = new frm_OgrenciIslemleri();
            KA.ShowDialog();
        }

        private void lbl_kitapverme_Click(object sender, EventArgs e)
        {
            frm_KitapVermeİslemi KVI = new frm_KitapVermeİslemi();
            KVI.Show();
        }

        private void lbl_kitaptakibi_Click(object sender, EventArgs e)
        {
            frm_KitapTakibi KT = new frm_KitapTakibi();
            KT.ShowDialog();
        }
    }
}
