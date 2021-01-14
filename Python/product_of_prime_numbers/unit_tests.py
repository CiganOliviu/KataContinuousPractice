import unittest
from product_of_prime_numbers import ProductEngine


class TestCaseProductOfPrimeNumbers(unittest.TestCase):

    product_engine = ProductEngine()

    def test_is_prime(self):
        self.assertEqual(self.product_engine.is_prime(13), True)
        self.assertEqual(self.product_engine.is_prime(26), False)
        self.assertEqual(self.product_engine.is_prime(2), True)

    def test_get_product_of_prime_numbers(self):
        self.assertEqual(self.product_engine.get_product_of_prime_numbers(12), 2310)
        self.assertEqual(self.product_engine.get_product_of_prime_numbers(8), 210)
        self.assertEqual(self.product_engine.get_product_of_prime_numbers(13), 30030)


if __name__ == '__main__':
    unittest.main()
