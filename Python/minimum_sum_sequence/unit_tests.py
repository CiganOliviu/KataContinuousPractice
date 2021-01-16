import unittest
from minimum_sum_sequence import MinimumSumSequence


class MinimumSumSequenceTestCase(unittest.TestCase):

    __sum_sequence_object = MinimumSumSequence()

    def test_minimum_sum_sequence(self):
        self.assertEqual(self.__sum_sequence_object.get_minimum_sum_sequence([5, -6, 3, 4, -2, 3, -3]), 8)


if __name__ == '__main__':
    unittest.main()
