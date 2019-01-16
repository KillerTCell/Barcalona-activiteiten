﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcelona
{
    class Leerling
    {
        private int _id;
        private string _voorNaam;
        private string _achterNaam;
        private string _klas;
        private string _gsmNummer;


		public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string voorNaam
        {
            get { return _voorNaam; }
            set { _voorNaam = value; }
        }
        public string achterNaam
        {
            get { return _achterNaam; }
            set { _achterNaam = value; }
        }
        public string klas
        {
            get { return _klas; }
            set { _klas = value; }
        }
        public string gsmNummer
        {
            get { return _gsmNummer; }
            set { _gsmNummer = value; }
        }

        public Leerling(int pintID ,string pstrVoornaam, string pstrAchternaam, string pstrKlas,
            string pstrGsmNummer)
        {
            _id = pintID;
            _voorNaam = pstrVoornaam;
            _achterNaam = pstrAchternaam;
            _klas = pstrKlas;
            _gsmNummer = pstrGsmNummer;
        }
        public Leerling(string pstrVoornaam, string pstrAchternaam, string pstrKlas,
            string pstrGsmNummer)
        {
            _voorNaam = pstrVoornaam;
            _achterNaam = pstrAchternaam;
            _klas = pstrKlas;
            _gsmNummer = pstrGsmNummer;
        }


	}
}
