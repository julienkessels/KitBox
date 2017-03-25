﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class corniere : IElement
    {
        private string _reference;
        private string _code;
        private string _color;

        private int _height;
        private int _depth;
        private int _width;
        private int _stock; //c'est plutot une variable de classe??
        private int _percase;
        private string _supplier;
        private double _clientprice;


        //Constructor
        public corniere(string reference, string code, int height, int depth, int width, int stock, int percase, string supplier, double clientprice)
        {
            _reference = reference;
            _code = code;
            _height = height;
            _depth = depth;
            _width = width;
            _stock = stock;
            _percase = percase;
            _supplier = supplier;
            _clientprice = clientprice;


        }
        public void generateCode()
        {
            this._code = "abc";
        }

        //Propoerty Implementation
        public string code { get { return _code; } }
        public string color { get { return _color; } set { this._color = value; } }

        public string reference { get { return _reference; } }
        public int height { get { return _height; } set { this._height = value; } }
        public int depth { get { return _depth; } }
        public int width { get { return _width; } }
        public int stock { get { return _stock; } }
        public int percase { get { return _percase; } }
        public string supplier { get { return _supplier; } }
        public double clientprice { get { return _clientprice; } }


    }
}