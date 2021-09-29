﻿using System;

namespace Exercises.Level2
{
    public class HalfTriangle
    {
        /// <summary>
        /// The program:
        ///  You must create a half triangle. 
        ///  n is the number of lines a triangle will have.
        ///  Triangle body has to be made out of "*",
        ///  so result should for 3 be like:
        ///* 
        ///***
        ///*****
        /// 
        /// Example of 5:
        /// 
        ///*
        ///***
        ///*****
        ///*******
        ///*********
        ///
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string[] GetHalfTriangle(int n)
        {
            string star = "*";
            string[] triangle = new string[n];
            for(int i=0; i<n; i++)
            {
                triangle[i] = star;
                star = star + "**";
            }
            return triangle;
        }
    }
}
