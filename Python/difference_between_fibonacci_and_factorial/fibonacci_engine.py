class IFibonacciEngine:
    def get_fibonacci_number(self, index: int):
        pass


class FibonacciEngine(IFibonacciEngine):

    @staticmethod
    def __is_value_one_or_zero(index: int):

        return index == 1 or index == 2

    def get_fibonacci_number(self, index: int):

        if self.__is_value_one_or_zero(index):
            return 1

        return self.get_fibonacci_number(index - 1) + self.get_fibonacci_number(index - 2)

