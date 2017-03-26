﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Porte : IElement
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

        private string _material;

        //Constructor
        public Porte(string color, int width, int height)
        {
            this._color = color;
            this._width = width;
            this._height = height;
        }

        public void generateCode()
        {
            string tmpCode = "";
            tmpCode += "POR";
            tmpCode += this._height.ToString();
            tmpCode += this._width.ToString();

            if(this._color.Contains("White"))
                tmpCode += "BL";
            else if (this._color.Contains("Brown"))
                tmpCode += "BR";
            else if (this._color.Contains("Aqua"))
                tmpCode += "VE";

            this._code = tmpCode;
        }
        private void colorCode()
        {

        }
        //Property Implementation
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

        public string material { get { return _material; } }

    }
}