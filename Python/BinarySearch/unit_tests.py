import unittest
import binary_search


class MyTestCase(unittest.TestCase):

    _binary_search_engine = binary_search.BinarySearch()

    def test_one_binary_search(self):
        self.assertEqual(self._binary_search_engine.search_by_binary_search([1, 2, 3, 4, 5], 3), 2)


    def test_two_binary_search(self):
        self.assertEqual(self._binary_search_engine.search_by_binary_search([-5, -4, -3, -2, -1], -4), 1)


if __name__ == '__main__':
    unittest.main()
