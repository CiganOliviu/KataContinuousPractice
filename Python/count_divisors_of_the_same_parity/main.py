from count_divisors import CountDivisorsEngine


def setup():
    count_divisors = CountDivisorsEngine()

    print(count_divisors.count_odd_divisors(12))
    print(count_divisors.count_odd_divisors(24))
    print(count_divisors.count_odd_divisors(3))

    print(count_divisors.count_even_divisors(12))
    print(count_divisors.count_even_divisors(24))
    print(count_divisors.count_even_divisors(3))


if __name__ == '__main__':
    setup()