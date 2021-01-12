class ILimitsEngine:

    def get_min_value_from_array(self, array: list) -> int:
        pass

    def get_max_value_from_array(self, array: list) -> int:
        pass


class LimitsEngine(ILimitsEngine):

    def get_min_value_from_array(self, array: list) -> int:
        result = array[0]

        for item in array:
            if item < result:
                result = item

        return result


    def get_max_value_from_array(self, array: list) -> int:
        result = array[0]

        for item in array:
            if item > result:
                result = item

        return result

