using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamasPizza
{
    public class Customer
    {
        #region Instants Fields 
        private string _customername;
        private int _phoneNumber;
        private string _addresse;
        #endregion

        #region Constuctor
        public Customer(string customerName, int phoneNumber, string addresse)
        {
            _customername = customerName;
            _phoneNumber = phoneNumber;
            _addresse = addresse;

        }
        #endregion

        #region Properties
        public string CustomerName
        {
            get
            { return _customername; }
            set
            { _customername = value; }
        }
         
        public int PhoneNumber
        {
            get
            { return _phoneNumber; }
            set
            { _phoneNumber = value; }
        }


        public string Addresse
        {
            get
            { return _addresse; }
            set
            { _addresse = value; }
        }
        #endregion

        #region Methode
        public override string ToString()
        {
            return $" CustomerName: {_customername}, PhoneNumber {_phoneNumber}, Addresse: {_addresse}";
        }
        #endregion
    }





}
