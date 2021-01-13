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

            left = self.get_left_value(array, left, middle, value_to_search)

            right = self.get_right_value(array, middle, right, value_to_search)

        return -1

    def get_right_value(self, array, middle, right, value_to_search):
        if self._is_value_bigger(array, middle, value_to_search):
            right = middle - 1
        return right

    def get_left_value(self, array, left, middle, value_to_search):
        if self._is_value_smaller(array, middle, value_to_search):
            left = middle + 1
        return left

    def _get_middle_value_between_limits(self, left, right):

        middle = left + (right - left) // 2
        return middle


    def _is_value_found(self, array: list, value_to_search: int, position: int):

        return array[position] == value_to_search


    def _is_value_smaller(self, array: list, position: int, value_to_search: int):

        return array[position] < value_to_search


    def _is_value_bigger(self, array: list, position: int, value_to_search: int):

        return array[position] > value_to_search

