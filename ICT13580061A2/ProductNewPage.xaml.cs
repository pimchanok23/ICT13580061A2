using System;
using System.Collections.Generic;
using ICT13580061A2.Models;
using Xamarin.Forms;

namespace ICT13580061A2
{
    public partial class ProductNewPage : ContentPage
    {
        Product product;

        public ProductNewPage(Product product = null)
        {
            InitializeComponent();

            this.product = product;
            titleLable.Text = product == null ? "เพิ่มรายการอาหารใหม่" : "แก้ไขข้อมูล";
            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;
            categoryPicker.Items.Add("ของคาว");
            categoryPicker.Items.Add("ขนมหวาน");
            categoryPicker.Items.Add("ของแซ่บ");
            if (product !=null)
            {
                nameEntry.Text = product.Name;
                descriptionEditor.Text = product.Description;
                categoryPicker.SelectedItem = product.Category;

            }


        }

        void SaveButton_Clicked(object sender, EventArgs e)
        {

        }

        void CancelButton_Clicked(object sender, EventArgs e)
        {

        }
    }
 }