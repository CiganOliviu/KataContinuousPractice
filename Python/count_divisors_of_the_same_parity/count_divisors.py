class ICountDivisors:

    def count_odd_divisors(self, factor: int) -> int:
        pass

    def count_even_divisors(self, factor: int) -> int:
        pass


class CountDivisorsEngine(ICountDivisors):

    def __is_odd(self, number: int) -> bool:
        return number % 2 == 1

    def __is_number_odd_divisor(self, factor: int, divisor: int) -> bool:
        return factor % divisor == 0 and self.__is_odd(divisor)

    def count_odd_divisors(self, factor: int) -> int:

        index = 0

        for divisor in range(2, factor + 1, 1):
            if self.__is_number_odd_divisor(factor, divisor):
                index += 1

        return index

    def __is_even(self, number: int) -> bool:
        return number % 2 == 0

    def __is_number_even_divisor(self, factor: int, divisor: int) -> bool:
        return factor % divisor == 0 and self.__is_even(divisor)

    def count_even_divisors(self, factor: int) -> int:

        index = 0

        for divisor in range(2, factor + 1, 1):
            if self.__is_number_even_divisor(factor, divisor):
                index += 1

        return index

