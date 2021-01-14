class IProductPrimeNumbers:

    def is_prime(self, number: int) -> bool:
        pass

    def get_product_of_prime_numbers(self, index: int) -> int:
        pass


class ProductEngine(IProductPrimeNumbers):

    @staticmethod
    def is_number_first_element_prime(number: int) -> bool:

        if number == 2:
            return True

        return False

    def is_prime(self, number: int) -> bool:

        if self.is_number_first_element_prime(number):
            return True

        for item in range(2, number, 1):
            if number % item == 0:
                return False

        return True

    def get_product_of_prime_numbers(self, index: int) -> int:

        index += 1
        product = 1

        for item in range(2, index, 1):
            if self.is_prime(item):
                product *= item

        return product
