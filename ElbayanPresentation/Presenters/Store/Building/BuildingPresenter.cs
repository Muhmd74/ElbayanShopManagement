﻿using ElbayaNPresentation.Presenters.CommonPresenter;
using ElbayanServices.Repository.Customers.Building;
using ElbayanServices.Repository.Customers.Building.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElbayaNPresentation.Presenters.Store.Building
{
    public class BuildingPresenter
    {
        private readonly IViewBuilding _view;
        private readonly BuildingService buildingService = new BuildingService(new ElbayanDatabase.ConnectionTools.ConnectionOption());

        public BuildingPresenter(IViewBuilding view)
        {
            _view = view;
        }

        public void OnloadUCBuilding()
        {
            DataGridViewStyle.StyleDatagridview(_view.dgvActiveObjects);
            DataGridViewStyle.StyleDatagridview(_view.dgvDeletedObjects);

            // Load Data Grid:
            PopualteActiveObjects();
            PopulateDeletedObject();
        }

        // Populate All Builing objects in Data Grid View
        // 2- Read:
        public void PopualteActiveObjects()
        {
            _view.dgvActiveObjects.DataSource = buildingService.GetAllBuilding().ToList();
        }
        public void PopulateDeletedObject()
        {
            // _view.dgvDeletedObjects.DataSource = buildingService.GetAllBuilding().ToList();
        }

         // CRUD Operation: 
         // 1- Create:
         public void CreateNewObject()
         {
            if(_view.BuildingName.Text != "")
           {
                buildingService.Create(new BuildingDto
                {
                    Name = _view.BuildingName.Text,
                    Description = _view.BuildingDescription.Text,
                    Address = _view.BuildingAddress.Text,
                    PhoneNumber = _view.BuildingPhoneNumber.Text
                });

                // Refresh DGV All Active Object:
                PopualteActiveObjects();
                ClearUcControls();
            }
            else
            {
                MessageBox.Show("كرما لا بد من إدخال حقل الإسم", "تأكيد", MessageBoxButtons.OK);
                return;
            }
         }

        private void ClearUcControls()
        {
            _view.BuildingName.Text = _view.BuildingDescription.Text
                = _view.BuildingAddress.Text = _view.BuildingPhoneNumber.Text = "";
        }
    }
}
