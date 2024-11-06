using System;
using ClassLibrary1;
using System.IO;
using System;
using Xunit;

namespace TestProject
{
        public class UnitTest1
        {
            Matrix matTesting;

            // ����������� ���������
            public UnitTest1()
            {
                run();
            }
            // ����� ������� ���������
            public void run()
            {
                RowsTest1();
                RowsTest2();
                ColsTest1();
                ColsTest2();
                SumSquaresGreaterThanTest1();
                SumSquaresGreaterThanTest2();
                SumSquaresAfterElementTest1();
                SumSquaresAfterElementTest2();
            }
            [Fact]
            // ���� �������� ���������� ����� � ������� - ������ ������
            public void RowsTest1()
            {
                double[,] rowTest1 = new double[,] { { 41, 8, 3, 15 }, { 16, 32, 2, 10 } }; //���������� �������
                int rezult = 0;
                matTesting = new Matrix(rowTest1); //������������� ���������� ����� ����������� Matrix � ��������� �������
                rezult = matTesting.Rows;
                Assert.Equal(2, rezult);
            }
            [Fact]
            // ���� �������� ���������� ����� � ������� - ������ ������
            public void RowsTest2()
            {
                double[,] rowTest2 = new double[,] { { 5 } };
                double rezult = 0;
                matTesting = new Matrix(rowTest2);
                rezult = matTesting.Rows;
                Assert.Equal(1, rezult);
            }
            [Fact]
            // ���� �������� ���������� �������� � ������� - ������ ������
            public void ColsTest1()
            {
                double[,] colTest1 = new double[,] { { 41, 8, 3, 15 }, { 16, 32, 2, 10 } };
                double rezult = 0;
                matTesting = new Matrix(colTest1);
                rezult = matTesting.Cols;
                Assert.Equal(4, rezult);
            }
            [Fact]
            // ���� �������� ���������� �������� � ������� - ������ ������
            public void ColsTest2()
            {
                double[,] colTest2 = new double[,] { { 5 } };
                double rezult = 0;
                matTesting = new Matrix(colTest2);
                rezult = matTesting.Cols;
                Assert.Equal(1, rezult);
            }
            [Fact]
            // ���� ���������� ����� ��������� ���������, ������� ��������� ����� - ������ ������
            public void SumSquaresGreaterThanTest1()
            {
                double[,] sumSquaresGreaterThanTest1 = new double[,] { { 41, 8, 3, 15 } };
                double rezult = 0;
                matTesting = new Matrix(sumSquaresGreaterThanTest1);
                rezult = matTesting.SumSquaresGreaterThan(14);
                Assert.Equal(1906, rezult);
            }
            [Fact]
            // ���� ���������� ����� ��������� ���������, ������� ��������� ����� - ������ ������
            public void SumSquaresGreaterThanTest2()
            {
                double[,] sumSquaresGreaterThanTest2 = new double[,] { { 5 } };
                double rezult = 0;
                matTesting = new Matrix(sumSquaresGreaterThanTest2);
                rezult = matTesting.SumSquaresGreaterThan(7);
                Assert.Equal(0, rezult);
            }
            [Fact]
            // ���� ���������� ����� ��������� ��������� ����� ��������� �������� (��������� � ����� ������ � ����� �������) - ������ ������
            public void SumSquaresAfterElementTest1()
            {
                double[,] sumSquaresAfterElementTest1 = new double[,] { { 41, 8, 3, 15 } };
                double rezult = 0;
                matTesting = new Matrix(sumSquaresAfterElementTest1);
                rezult = matTesting.SumSquaresAfterElement(1, 1);
                Assert.Equal(0, rezult);
            }
            [Fact]
            // ���� ���������� ����� ��������� ��������� ����� ��������� �������� (��������� � ����� ������ � ����� �������) - ������ ������
            public void SumSquaresAfterElementTest2()
            {
                double[,] sumSquaresAfterElementTest2 = new double[,] { { 41, 8, 3, 15 } };
                double rezult = 0;
                matTesting = new Matrix(sumSquaresAfterElementTest2);
                rezult = matTesting.SumSquaresAfterElement(1, 2);
                Assert.Equal(0, rezult);
            }
        public class UnitTest
        {
            [Fact]
            public void SumSquaresAfterElementTest1()
            {
                double[,] sumSquaresAfterElementTest1 = new double[,] { { 41, 8, 3, 15 } };
                Matrix matTesting = new Matrix(sumSquaresAfterElementTest1);
                double result = matTesting.SumSquaresAfterElement(1, 1);
                Assert.Equal(0, result);
            }
        }

    }
}