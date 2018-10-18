import random

GENES = {
    1 : 100,
    2 : 10,
    3 : -50,
    4 : 200
}

DONE = 200 * 8

def random_gene():
    return random.randint(1,4)

class Individuum:
    def __init__(self,genes):
        self.genes = genes
        self.fitness = float(sum(GENES[gene] \
            for gene in self.genes))
        self.weight = None

    def split(self, index):
        return self.genes[:index], self.genes[index:]

    def __repr__(self):
        ret = ""
        for gene in self.genes:
            ret += str(gene) + " "
        ret += "=> fitness: %.0f" % self.fitness

        if self.weight is not None:
            ret += " weight: %.5f" % self.weight

        return ret

class Population:
    def __init__(self, size, genes, propability_mutation):
        self.size = size
        self.genes = genes
        self.propability_mutation = propability_mutation
        self.population = [Individuum([random_gene() \
            for gene in range(genes)]) \
                for individuum in range(size)]

    def run(self):
        iteration = 0
        while self.done() is not True:
            print("ITERATION: " + str(iteration))
            self.weight()
            self.select()
            self.crossover()
            self.mutate()
            iteration += 1

        return [individuum for individuum \
            in self.population \
            if individuum.fitness == DONE][0], iteration

    def weight(self):
        fitness_ges = float(sum(individuum.fitness \
            for individuum in self.population))

        for individuum in self.population:
            individuum.weight = \
                individuum.fitness / fitness_ges

    def select(self):
        self.population = sorted(
            self.population,
            key=lambda x: x.weight,
            reverse=True
        )

    def crossover(self):
        for i in range(0,self.size,2):
            crossover_point = \
                random.randint(0,self.genes - 1)

            msb_individuum_x, lsb_individuum_x = \
                self.population[i].split(crossover_point)

            msb_individuum_y, lsb_individuum_y = \
                self.population[i+1].split(crossover_point)

            self.population[i] = Individuum(
                msb_individuum_x + lsb_individuum_y)

            self.population[i+1] = Individuum(
                msb_individuum_y + lsb_individuum_x)

    def mutate(self):
        for i in range(self.size):
            mutate = random.random()
            if mutate <= self.propability_mutation:
                index = random.randint(0,self.genes - 1)
                mutation = random_gene()
                self.population[i].genes[index] = mutation
                self.population[i] = Individuum(
                    self.population[i].genes)

    def done(self):
        for individuum in self.population:
            if individuum.fitness >= DONE:
                return True
        return False

def main():
    print(Population(1000,8,0.1).run())

if __name__ == '__main__':
    main()
