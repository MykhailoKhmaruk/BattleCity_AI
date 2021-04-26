/*-
 * #%L
 * Codenjoy - it's a dojo-like platform from developers to developers.
 * %%
 * Copyright (C) 2018 - 2021 Codenjoy
 * %%
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public
 * License along with this program.  If not, see
 * <http://www.gnu.org/licenses/gpl-3.0.html>.
 * #L%
 */
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Battlecity.API;

namespace Demo
{
    internal class YourSolver : AbstractSolver
    {
        public YourSolver(string server) : base(server) { }

        /// <summary>
        /// Is called on each move to make decision what to do (next move)
        /// </summary>
        protected override string Get(Board board)
        {
            // Sample code
            Point myPos = board.GetMe();
            



            string action = Direction.Act.ToString() + Direction.Left.ToString(); //Element.BULLET.ToString();//+ Direction.Up.ToString();
            return action;
        }

        //protected Direction getFirstDirectionForAct(Board board, Point myPos)
        //{
        //    Element[] arrElements = new Element[4] { Element.NONE, Element.NONE, Element.NONE, Element.NONE}; //UP DOWN RIGHT LEFT
        //    int[] i_arr = new[] {1, 1, 1, 1};
        //    //check UP
        //    while (IsDESTROYEDWALL(arrElements[0]) || arrElements[0] == Element.BATTLE_WALL || IsEnemy(arrElements[0]) || arrElements[0] == Element.BULLET)
        //    {
        //        arrElements[0] = board.GetAt(new Point(myPos.X, myPos.Y + i_arr[0]));
        //        i_arr[0]++;
        //    }
        //    //check DOWN
        //    while (IsDESTROYEDWALL(arrElements[1]) || arrElements[1] == Element.BATTLE_WALL || IsEnemy(arrElements[1]) || arrElements[1] == Element.BULLET)
        //    {
        //        arrElements[1] = board.GetAt(new Point(myPos.X, myPos.Y + i_arr[1]));
        //        i_arr[1]++;
        //    }
        //    //check RIGHT
        //    while (IsDESTROYEDWALL(arrElements[2]) || arrElements[2] == Element.BATTLE_WALL || IsEnemy(arrElements[2]) || arrElements[2] == Element.BULLET)
        //    {
        //        arrElements[2] = board.GetAt(new Point(myPos.X, myPos.Y + i_arr[2]));
        //        i_arr[2]++;
        //    }
        //    //check LEFT
        //    while (IsDESTROYEDWALL(arrElements[3]) || arrElements[3] == Element.BATTLE_WALL || IsEnemy(arrElements[3]) || arrElements[3] == Element.BULLET)
        //    {
        //        arrElements[3] = board.GetAt(new Point(myPos.X, myPos.Y + i_arr[3]));
        //        i_arr[3]++;
        //    }

        //    int i_MAX = i_arr.Max();
        //    Element e_MAX = arrElements.Max();
        //    if (e_MAX == Element.BULLET)
        //    {

        //    }
        //    //else if (e_MAX == Elemen

        //    return Direction.Down;
        //}






        protected bool IsDESTROYEDWALL(Element element) =>
            element >= Element.WALL && element <= Element.WALL_DESTROYED_DOWN_RIGHT;
        protected bool IsEnemy(Element element) =>
            element >= Element.OTHER_TANK_UP && element <= Element.AI_TANK_LEFT;

    }
}
