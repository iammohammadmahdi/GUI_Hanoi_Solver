using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Hanoi_Solver
{
    class HanoiSolver
    {
        HanoiGame game;

        public HanoiSolver(HanoiGame game)
        {
            this.game = game;
        }

        public void Solve()
        {
            ConstructTower(game.blockCount, game.towers[2], game.towers[1], game.towers[0]);
        }

        void ConstructTower(int blockCount, Tower target, Tower side, Tower from)
        {
            if (blockCount <= 0)
            {
                return;
            }
            ConstructTower(blockCount - 1, side, target, from);
            game.MoveBlock(from, target);
            ConstructTower(blockCount - 1, target, from, side);
        }
    }
}
