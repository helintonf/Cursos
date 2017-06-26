# Snake Game!

#our game imports
import sys, random, time, pygame

class GameSnake(object):
    score = 0
    fpsController = pygame.time.Clock()
    red = pygame.Color(255,0,0)#Game over
    green = pygame.Color(0,255,0) #snake
    black = pygame.Color(0,0,0)#score
    white = pygame.Color(255,255,255)#background
    brown = pygame.Color(165,42,42)#food

    def __init__(self, display):
        self.playSurface = pygame.display.set_mode((display[0], display[1]))
        self.display = display

    def gameOver(self):
        myFont = pygame.font.SysFont('monaco', 72)
        GOsurf = myFont.render('Game Over!', True, self.red)
        GOrect = GOsurf.get_rect()
        GOrect.midtop = (360, 15)
        self.playSurface.blit(GOsurf, GOrect)    
        self.showScore(0)
        pygame.display.flip()
        time.sleep(5)
        pygame.quit() # pygame exit
        sys.exit() # console exit
    
    def verificar(self, position):
        if position[0] > (self.display[0] -10) or position[0]< 0:
            self.gameOver()
        if position[1] > (self.display[1] -10)  or position[1] < 0:
            self.gameOver()
    
    def showScore(self, choice=1):
        sFont = pygame.font.SysFont('monaco', 24)
        sSurf = sFont.render('Score: {0}'.format(self.score), True, self.black)
        sRect = sSurf.get_rect()
        if choice == 1:
            sRect.midtop = (80, 10)
        else:
            sRect.midtop = (360, 120)
        self.playSurface.blit(sSurf, sRect)
    
    def drawObject(self,color,position):
        pygame.draw.rect(self.playSurface, color, pygame.Rect(position[0], position[1], 10, 10))

class Food(object):
    position = [random.randrange(1, 72)*10, random.randrange(1, 46)*10]
    spawn = True

class Snake(object):
    speed = 20
    position = [100, 50]
    body = [[100, 50],[90, 50], [80, 50]]
    direction = 'RIGHT'

    def changeDirection(self, changeTo):

        if changeTo == 'RIGHT' and not self.direction == 'LEFT':
            self.direction = 'RIGHT'
        if changeTo == 'LEFT' and not self.direction == 'RIGHT':
            self.direction = 'LEFT'
        if changeTo == 'UP' and not self.direction == 'DOWN':
            self.direction = 'UP'
        if changeTo == 'DOWN' and not self.direction == 'UP':
            self.direction = 'DOWN'

    def move(self):
    
        if self.direction == 'RIGHT':
            self.position[0] += 10
        if self.direction == 'LEFT':
            self.position[0] -= 10
        if self.direction == 'UP':
            self.position[1] -= 10
        if self.direction == 'DOWN':
            self.position[1] += 10

        self.body.insert(0, list(self.position))

check_errors = pygame.init()

if check_errors[1] > 0 :
    print("(!) Had {0} initializing errors, existing...".format(check_errors[1]))
    sys.exit(-1)
else:
    print("(+) PyGame successfully initialized!")

#Play surface
gsk = GameSnake([720,460])

pygame.display.set_caption('Snake Game!')

snk = Snake()
fd = Food()

# Main Logic of the game
while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            sys.exit()
        elif event.type == pygame.KEYDOWN:
            if event.key == pygame.K_RIGHT or event.key == ord('d'):
                snk.changeDirection('RIGHT')
            if event.key == pygame.K_LEFT or event.key == ord('a'):
                snk.changeDirection('LEFT')
            if event.key == pygame.K_UP or event.key == ord('W'):
                snk.changeDirection('UP')
            if event.key == pygame.K_DOWN or event.key == ord('S'):
                snk.changeDirection('DOWN')
            if event.key == pygame.K_ESCAPE:
                pygame.event.post(pygame.event.Event(pygame.QUIT))

    snk.move()

    if snk.position[0] == fd.position[0] and  snk.position[1] == fd.position[1]:
        gsk.score += 1
        snk.speed += 2
        fd.spawn = False
    else:
        snk.body.pop()

    if fd.spawn == False:
        fd.position = [random.randrange(1, 72) * 10, random.randrange(1, 46) * 10]
    fd.spawn = True

    gsk.playSurface.fill(gsk.white)

    for pos in snk.body:
        gsk.drawObject(gsk.green,pos)

    gsk.drawObject(gsk.brown, fd.position)
    gsk.verificar(snk.position)

    for block in snk.body[1:]:
        if snk.position[0] == block[0] and snk.position[1] == block[1]:
            gsk.gameOver()
    gsk.showScore()
    pygame.display.flip()
    gsk.fpsController.tick(snk.speed)