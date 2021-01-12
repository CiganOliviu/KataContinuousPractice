import unittest
import limits_engine


class MyTestCase(unittest.TestCase):

    _limits_engine = limits_engine.LimitsEngine

    def test_get_min_from_array(self):
        self.assertEqual(self._limits_engine.get_min_value_from_array(self._limits_engine, [1, 2, 3, 4, 5]), 1)

    def test_get_max_from_array(self):
        self.assertEqual(self._limits_engine.get_max_value_from_array(self._limits_engine, [1, 2, 3, 4, 5]), 5)


if __name__ == '__main__':
    unittest.main()
