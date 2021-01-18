import unittest
from fibonacci_engine import FibonacciEngine
from factorial_engine import FactorialEngine


class FibonacciTestCase(unittest.TestCase):

    __fibonacci = FibonacciEngine()

    def test_fibonacci(self):
        self.assertEqual(self.__fibonacci.get_fibonacci_number(8), 21)
        self.assertEqual(self.__fibonacci.get_fibonacci_number(12), 144)
        self.assertEqual(self.__fibonacci.get_fibonacci_number(2), 1)
        self.assertEqual(self.__fibonacci.get_fibonacci_number(5), 5)


class FactorialTestCase(unittest.TestCase):

    __factorial = FactorialEngine()

    def test_factorial(self):
        self.assertEqual(self.__factorial.get_factorial_number(3), 6)
        self.assertEqual(self.__factorial.get_factorial_number(7), 5040)
        self.assertEqual(self.__factorial.get_factorial_number(5), 120)
        self.assertEqual(self.__factorial.get_factorial_number(0), 1)


if __name__ == '__main__':
    unittest.main()
