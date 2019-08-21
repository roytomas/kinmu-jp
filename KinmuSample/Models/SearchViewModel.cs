using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KinmuSample.Models
{
    public class SearchViewModel
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string EndDate { get; set; }

        [Display(Name="全社")]
        public bool IsCompanyWideSelected { get; set; }

        public bool IsDepartmentSelected { get; set; }

        public string DepartmentCode { get; set; }

        public string DepartmentName { get; set; }

        public string WorkgroupCode { get; set; }

        [Display(Name = "下位部門も含める")]
        public bool IsIncludeSubDivision { get; set; }

        [Display(Name = "事業所選択")]
        public bool IsOfficeSelected { get; set; }

        [Display(Name = "サブグループ選択")]
        public bool IsSubgroupSelected { get; set; }

        public bool IsIndividualSelected { get; set; }

        [Display(Name = "出向者を除")]
        public bool IsEmployeeExluded { get; set; }

    }
}