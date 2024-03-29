﻿using System;
using System.Linq;
namespace LuckySpin.ViewModels
{
    public class SpinViewModel
    {
        
        /*
         * Instance variables and constants
         */
        private const decimal costForOnePlay = 0.50m;
        private const decimal winningSpinValue = 1.00m;
        private System.Random random = new System.Random();

        private decimal _balance;
        private int[] _numbers;
        private int _luck;

        /*
         * Constructor
         */
        public SpinViewModel()
        {
            _numbers = new int[] { random.Next(1, 10), random.Next(1, 10), random.Next(1, 10) };
        }

        /*
         * Simple Properties - used only to shuttle data, no instance variable
         */
        public string FirstName { get; set; }

        /*
         * Complex Properties - used in the game logic, connected with an instance variable
         */

        //Read-Write Properties
        public int Luck
        {
            get { return _luck; }
            set { _luck = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        //Read-Only Properties
        public int[] Numbers
        {
            get { return _numbers; }
        }
        public bool Winner
        {
            get { return _numbers.Contains(_luck); }
        }

        /*
         * Game Play Methods 
         */
        public bool ChargeSpin()
        {
            if (_balance >= costForOnePlay)
            {
                _balance -= costForOnePlay;
                return true;
            }
            return false;
        }
        public void CollectWinnings()
        {
            _balance += winningSpinValue;
        }
        
    }
}
