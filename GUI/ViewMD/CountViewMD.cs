using GUI.Model;
using GUI.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GUI.ViewMD
{
    class CountViewMD:ViewModelBase
    {
        private string _count;
        public string count { get => _count; set { _count = value; OnPropertyChanged(); } }


        public ICommand OrderCommand { get; set; }
        
        public CountViewMD()
        {
            OrderCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(count))
                    return false;
                return true;
            }, (p) =>
            {
                System.Windows.MessageBox.Show("Thêm thành công!");
                var billinfo = new BillInfo() {count = Int32.Parse(count), idBill = OrderViewMD.idbill, idProduct = CountView.id, totalbillinfo = CountView.price0 * Int32.Parse(count) };

                DataProvider.Ins.DB.BillInfoes.Add(billinfo);
                DataProvider.Ins.DB.SaveChanges();
            });
        }
    }
}
