﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜: 2022/07/12
 * 내용: 자료형 실습하기 교재 p63
 * 
 * 자료형(Data Type)
 *  - 변수에 저장되는 데이터이 종류와 크기를 자료형으로 선언
 *  - 자료형은 크게 기본형과 참조형으로 나뉨
 */

namespace Ch2
{
    internal class _2_자료형
    {
        static void Main(string[] args)
        {


            //정수형
            sbyte num1 = 127;         // 1byte
            //127까지만 저장 가능     
            short num2 = 32767;        // 2byte
            int num3 = 2147483647;     // 4byte
            long num4 = 92233730368477507L; // 8byte

            Console.WriteLine("num1 : {0}", num1);
            Console.WriteLine("num1 : {0}", num2);
            Console.WriteLine("num1 : {0}", num3);
            Console.WriteLine("num1 : {0}", num4);

            //실수형
            float var1 = 0.123456789f; //8자리
            double var2 = 0.12345678901234567890; //17 자리

            Console.WriteLine("var1 : " + var1); 
            Console.WriteLine("var2 : " + var2); 

            //논리형
           bool b1 = true;
            bool b2 = false;

            Console.WriteLine("b1 : " + b1);
            Console.WriteLine("b2 : " + b2);


            //문자형
            char c1 = 'A';
            char c2 = '가';
            Console.WriteLine("c1 :" + c1);
            Console.WriteLine("c2 :" + c2);

            //문자열

            string str1 = "A";
            string str2 = "가";
            string str3 = "Apple";
            string str4 = "안녕하세요.";
            string str5 = "10"; // 숫자 X 문자열

            Console.WriteLine("str1 : " + str1);
            Console.WriteLine("str2 : " + str2);
            Console.WriteLine("str3 : " + str3);
            Console.WriteLine("str4 : " + str4);
            Console.WriteLine("str5 : " + str5);

            // object형
            object obj1 = 10;
            object obj2 = 3.14;
            object obj3 = true;
            object obj4 = 'A';
            object obj5 = "Apple";

            Console.WriteLine("0bj1 :"+obj1);
            Console.WriteLine("0bj2 :"+obj2);
            Console.WriteLine("0bj3 :"+obj3);
            Console.WriteLine("0bj4 :"+obj4);
            Console.WriteLine("0bj5 :"+obj5);

            // var형 
            var v1 = 10;
            var v2 = 3.14;
            var v3 = true;
            var v4 = 'A';
            var v5 = "Apple";

            Console.WriteLine("v1 :"+v1);
            Console.WriteLine("v2 :"+v2);
            Console.WriteLine("v3 :"+v3);
            Console.WriteLine("v4 :"+v4);
            Console.WriteLine("v5 :"+v5);
        }
    }
}
