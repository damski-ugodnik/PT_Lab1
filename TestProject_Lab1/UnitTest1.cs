using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;
using System;

namespace TestProject_Lab1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// ����� ������������ ������ Add() c ���������� ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestAdd_R()
        {
            double x = 5;
            double y = 45.6;
            double expected = 50.6;
            double actual = MyCalc.Add(x, y);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ����� ������������ ������ Add() c ������������ ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestAdd_W()
        {
            double x = -5;
            double y = 35.6;
            double expected = -4.6;
            double actual = MyCalc.Add(x, y);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ����� ������������ ������ Sub() c ���������� ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestSub_R()
        {
            double x = -5.4;
            double y = 35.09;
            double expected = -40.49;
            double actual = MyCalc.Sub(x, y);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ����� ������������ ������ Sub() c ������������ ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestSub_W()
        {
            double x = 1;
            double y = -5;
            double expected = -4;
            double actual = MyCalc.Sub(x, y);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ����� ������������ ������ Mul() c ���������� ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestMul_R()
        {
            double x = 3;
            double y = -6;
            double expected = -18;
            double actual = MyCalc.Mul(x, y);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ����� ������������ ������ Mul() c ������������ ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestMul_W()
        {
            double x = -5;
            double y = -4;
            double expected = -20;
            double actual = MyCalc.Mul(x, y);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ����� ������������ ������ Div() c ���������� ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestDiv_R()
        {
            double x = 4;
            double y = 2;
            double expected = 2;
            double actual = MyCalc.Div(x, y);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ����� ������������ ������ Div() c ������������ ��������� �����������
        /// </summary>
        [TestMethod]
        public void TestDiv_W()
        {
            double x = 1;
            double y = -5;
            double expected = -4;
            double actual = MyCalc.Div(x, y);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// ����� ������������ ������ Div() c ������������ �����������
        /// </summary>
        [TestMethod]
        public void TestDiv_Ex()
        {
            double x = 5;
            double y = 0;
            try { MyCalc.Div(x, y); }
            catch (Exception e) { Assert.Fail(e.Message); }
        }
    }
}
