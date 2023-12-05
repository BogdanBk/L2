using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Address
    {
        private string country;
        private string city;
        private int index;
        private int house;
        private int apartment;

        public string GetCountry() { return country; }
        public void SetCountry(string country) { this.country = country; }
        public string GetCity() { return city; }
        public void SetCity(string city) {  this.city = city; }
        public int GetIndex() { return index; }
        public void SetIndex(int index) {  this.index = index; }
        public int GetHouse() { return house; }
        public void SetHouse(int house) {  this.house = house; }
        public int GetApartment() {  return apartment; }
        public void SetApartment(int apartment) {  this.apartment = apartment; }

        public override string? ToString()
        {
            return $"{index}, {country}, {city}, {house}, {apartment}";
        }
    }
