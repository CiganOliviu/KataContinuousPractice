from sorting_engine import SortEngine


def setup():
    sorter = SortEngine()

    print(sorter.sort_array([5, 4, 3, 2, 1]))
    print(sorter.sort_array([-1, -2, -3, -4, -5]))
    print(sorter.sort_array([12, -12, 4, 3, 2, 1]))


if __name__ == '__main__':
    setup()