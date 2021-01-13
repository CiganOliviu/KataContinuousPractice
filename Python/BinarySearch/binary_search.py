class IBinarySearch:

    def search_by_binary_search(self, array: list, value_to_search: int) -> int:
        pass


class BinarySearch(IBinarySearch):

    def search_by_binary_search(self, array: list, value_to_search: int) -> int:

        right = len(array)
        left = 0

        while left <= right:
            middle = self._get_middle_value_between_limits(left, right)

            if self._is_value_found(array, value_to_search, middle):
                return middle

            if self._is_value_smaller(array, middle, value_to_search):
                left = middle + 1

            if self._is_value_bigger(array, middle, value_to_search):
                right = middle - 1

        return -1


    def _get_middle_value_between_limits(self, left, right):

        middle = left + (right - left) // 2
        return middle


    def _is_value_found(self, array: list, value_to_search: int, position: int):

        return array[position] == value_to_search


    def _is_value_smaller(self, array: list, position: int, value_to_search: int):

        return array[position] < value_to_search


    def _is_value_bigger(self, array: list, position: int, value_to_search: int):

        return array[position] > value_to_search

