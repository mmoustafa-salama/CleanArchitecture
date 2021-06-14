﻿using System.Threading.Tasks;
using BlazorWasmApp.Services;
using BlazorWasmApp.ViewModels.DepartmentsViewModels;

namespace BlazorWasmApp.Components.Pages.DepartmentComponents
{
    public partial class DepartmentDetailsModalComponent
    {
        private readonly DepartmentService _departmentService;

        public DepartmentDetailsModalComponent(DepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        private string ModalClass { get; set; } = string.Empty;

        private bool ShowBackdrop { get; set; }

        private DepartmentDetailsViewModel DepartmentDetailsModel { get; set; }

        public async Task ShowAsync(int departmentId)
        {
            DepartmentDetailsModel = await _departmentService.GetByIdAsync(departmentId);
            ModalClass = "show d-block";
            ShowBackdrop = true;
            StateHasChanged();
        }

        private void Close()
        {
            ModalClass = string.Empty;
            ShowBackdrop = false;
            StateHasChanged();
        }
    }
}