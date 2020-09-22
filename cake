class cake:
    def __init__(self,name,kind,taste,additions,filing):
        self.name = name
        self.kind = kind
        self.taste = taste
        self.additions = additions
        self.filing = filing


    def showinfo(self):
        print(self.name.upper())
        print(self.taste)
        if len(self.additions) > 0:
            print(self.additions)
        if len(self.filing) > 0:
            print(self.filing)

    def set_filing(self, filing):
        self.filing = filing



cake01 = cake('cwel','duzy','smaczyny','posypka','kremowa')
cake02 = cake('ultimate','small','delicious','choclate stars','creamy')
print(cake01.name,cake01.taste)
print(cake02.name,cake02.filing)


bakery_offer = []
bakery_offer.append(cake01)
bakery_offer.append(cake02)

print('today in our offers')
for c in bakery_offer:
    print("{} - ({}) main taste: {} with additives of {}, filled with {}".format(
        c.name, c.kind, c.taste, c.additions, c.filing))

cake01.showinfo()
