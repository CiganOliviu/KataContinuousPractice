class IMinimumSumSequence:

    def get_minimum_sum_sequence(self, array: list) -> int:
        pass


class MinimumSumSequence(IMinimumSumSequence):

    def get_minimum_sum_sequence(self, array: list) -> int:

        sum_of_elements = 0
        result = 0

        for item in array:

            sum_of_elements += item

            result = max(result, sum_of_elements)
            sum_of_elements = max(sum_of_elements, 0)

        return result

