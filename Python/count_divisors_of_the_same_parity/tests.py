import unittest
from count_divisors import CountDivisorsEngine


class CountDivisorsTestCase(unittest.TestCase):
    _count_divisors = CountDivisorsEngine()

    def test_count_odd_divisors_(self):
        self.assertEqual(self._count_divisors.count_odd_divisors(12), 1)
        self.assertEqual(self._count_divisors.count_odd_divisors(24), 1)
        self.assertEqual(self._count_divisors.count_odd_divisors(3), 1)

    def test_count_even_divisors_(self):
        self.assertEqual(self._count_divisors.count_even_divisors(12), 4)
        self.assertEqual(self._count_divisors.count_even_divisors(24), 6)
        self.assertEqual(self._count_divisors.count_even_divisors(3), 0)


if __name__ == '__main__':
    unittest.main()
