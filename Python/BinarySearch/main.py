import binary_search


_binary_engine = binary_search.BinarySearch()

if __name__ == '__main__':
    print(_binary_engine.search_by_binary_search([1, 2, 3, 4, 5], 3))
    print(_binary_engine.search_by_binary_search([-5, -4, -3, -2, -1], -2))

