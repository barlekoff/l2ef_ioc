using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Model;
using DataAccessLayer;
using System.Collections.Generic;
using System;

namespace BusinessLogic
{
    public class Logic : INotifyPropertyChanged
    {
        IRepository<Employee> db;

        public Logic(IRepository<Employee> r)
        {

            db = r;
        }

        //Реализация интерфейса INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        //Коллекция сотрудников для вывода и переменная для выбранного сотрудника
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();

        private Employee currentEmployee;
        public Employee CurrentEmployee
        {
            get { return currentEmployee; }
            set
            {
                currentEmployee = value;
                OnPropertyChanged("CurrentEmployee");
                if (CurrentEmployee != null)
                {
                    eName = CurrentEmployee.Name;
                    eAge = CurrentEmployee.Age.ToString();
                    ePost = CurrentEmployee.Post;
                    eSalary = CurrentEmployee.Salary.ToString();
                }
            }
        }

        /*
         *  Переменные, к которым привязаны текстовые поля на форме
         */

        private string _name;
        public string eName
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("eName");
            }
        }

        private string _post;
        public string ePost
        {
            get { return _post; }
            set
            {
                _post = value;
                OnPropertyChanged("ePost");
            }
        }

        private string _age;
        public string eAge
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("eAge");
            }
        }

        private string _salary;
        public string eSalary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged("eSalary");
            }
        }


        /*
         *  Команды
         */
        private ICommand getEmpsCommand;
        public ICommand GetEmpsCommand => getEmpsCommand ?? (getEmpsCommand = new RelayCommand(GetEmps));

        private ICommand delEmpCommand;
        public ICommand DelEmpCommand => delEmpCommand ?? (delEmpCommand = new RelayCommand(DeleteEmp));

        private ICommand updEmpCommand;
        public ICommand UpdEmpCommand => updEmpCommand ?? (updEmpCommand = new RelayCommand(UpdateEmp));

        /*
         *  Методы
         */

        //Получаем ребятишек из базы данных
        public void GetEmps()
        {
            Employees.Clear();

            List<Employee> emps = db.GetEmpList().ToList();
            foreach (Employee e in emps)
            {
                Employees.Add(e);
            }
        }

        //Удаление выбранного сотрудника из списка (на самом деле, по айди)
        public void DeleteEmp()
        {
            if (CurrentEmployee != null)
            {
                int id = CurrentEmployee.EmployeeId;
                db.DeleteEmp(id);
                db.Save();
            }
        }

        //Обновление выбранного сотрудника, поля берутся из формы
        public void UpdateEmp()
        {
            if (CurrentEmployee != null)
            {
                if (eName != null) { CurrentEmployee.Name = eName; }
                if (ePost != null) { CurrentEmployee.Post = ePost; }
                if (eAge != null) { CurrentEmployee.Age = Convert.ToInt32(eAge); }
                if (eSalary != null) { CurrentEmployee.Salary = Convert.ToInt32(eSalary); }

                db.UpdateEmp(CurrentEmployee);
                db.Save();
            }
        }
    }
}
