from fibonacci_engine import FibonacciEngine
from factorial_engine import FactorialEngine


def setup():
    __fibonacci = FibonacciEngine()
    __factorial = FactorialEngine()

    print(__fibonacci.get_fibonacci_number(7) - __factorial.get_factorial_number(7))


if __name__ == '__main__':
    setup()

