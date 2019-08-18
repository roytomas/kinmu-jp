using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace KinmuSample.Areas.Shoukai.Models.ViewModels
{
    public class KinmuData
    {
        [DisplayName("氏名")]
        public string kojin_name { get; set; }
        [DisplayName("部門")]
        public string bumon { get; set; }
        [DisplayName("勤務時間")]
        public int kinmu_jikan { get; set; }
        [DisplayName("不就業時間")]
        public Nullable<int> husyuugyou_jikan { get; set; }

    }
}