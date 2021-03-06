/*
 * Copyright (c) Contributors, http://opensimulator.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the OpenSimulator Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using OpenMetaverse;
using OpenSim.Region.Framework.Scenes;

namespace OpenSim.Region.Framework.Interfaces
{
    public interface INPCModule
    {
        /// <summary>
        /// Create an NPC
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="position"></param>
        /// <param name="scene"></param>
        /// <param name="cloneAppearanceFrom">The UUID of the avatar from which to clone the NPC's appearance from.</param>
        /// <returns>The UUID of the ScenePresence created.</returns>
        UUID CreateNPC(string firstname, string lastname, Vector3 position, Scene scene, UUID cloneAppearanceFrom);

        /// <summary>
        /// Move an NPC to a target over time.
        /// </summary>
        /// <param name="agentID">The UUID of the NPC</param>
        /// <param name="scene"></param>
        /// <param name="pos"></param>
        void MoveToTarget(UUID agentID, Scene scene, Vector3 pos);

        /// <summary>
        /// Get the NPC to say something.
        /// </summary>
        /// <param name="agentID">The UUID of the NPC</param>
        /// <param name="scene"></param>
        /// <param name="text"></param>
        void Say(UUID agentID, Scene scene, string text);


        /// <summary>
        /// Delete an NPC.
        /// </summary>
        /// <param name="agentID">The UUID of the NPC</param>
        /// <param name="scene"></param>
        void DeleteNPC(UUID agentID, Scene scene);
    }
}