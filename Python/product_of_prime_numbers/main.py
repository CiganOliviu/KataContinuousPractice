from product_of_prime_numbers import ProductEngine

product_engine = ProductEngine()


def get_results():
    print(product_engine.get_product_of_prime_numbers(12))
    print(product_engine.get_product_of_prime_numbers(8))
    print(product_engine.get_product_of_prime_numbers(13))


if __name__ == '__main__':
    get_results()