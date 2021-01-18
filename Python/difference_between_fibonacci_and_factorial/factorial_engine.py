class IFactorialEngine:
    def get_factorial_number(self, index: int):
        pass


class FactorialEngine(IFactorialEngine):

    def get_factorial_number(self, index: int):
        if index == 0:
            return 1

        return index * self.get_factorial_number(index - 1)



