import unittest
from sorting_engine import SortEngine


class TestCaseSortEngine(unittest.TestCase):

    __sorter = SortEngine()

    def test_sort_array_(self):
        self.assertEqual(self.__sorter.sort_array([5, 4, 3, 2, 1]), [1, 2, 3, 4, 5])
        self.assertEqual(self.__sorter.sort_array([-1, -2, -3, -4, -5]), [-5, -4, -3, -2, -1])
        self.assertEqual(self.__sorter.sort_array([12, -12, 4, 3, 2, 1]), [-12, 1, 2, 3, 4, 12])


if __name__ == '__main__':
    unittest.main()
