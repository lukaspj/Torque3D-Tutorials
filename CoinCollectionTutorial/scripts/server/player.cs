// Timeouts for corpse deletion.
$CorpseTimeoutValue = 45 * 1000;

// // Damage Rate for entering Liquid
// $DamageLava = 0.01;
// $DamageHotLava = 0.01;
// $DamageCrustyLava = 0.01;

// Death Animations
$PlayerDeathAnim::TorsoFrontFallForward = 1;
$PlayerDeathAnim::TorsoFrontFallBack = 2;
$PlayerDeathAnim::TorsoBackFallForward = 3;
$PlayerDeathAnim::TorsoLeftSpinDeath = 4;
$PlayerDeathAnim::TorsoRightSpinDeath = 5;
$PlayerDeathAnim::LegsLeftGimp = 6;
$PlayerDeathAnim::LegsRightGimp = 7;
$PlayerDeathAnim::TorsoBackFallForward = 8;
$PlayerDeathAnim::HeadFrontDirect = 9;
$PlayerDeathAnim::HeadBackFallForward = 10;
$PlayerDeathAnim::ExplosionBlowBack = 11;
/*
datablock PlayerData(DefaultPlayerData)
{
   renderFirstPerson = false;

   computeCRC = false;

   // Third person shape
   shapeFile = "art/shapes/actors/Soldier/soldier_rigged.dae";
   cameraMaxDist = 3;
   allowImageStateAnimation = true;

   canObserve = 1;
   cmdCategory = "Clients";

   cameraDefaultFov = 55.0;
   cameraMinFov = 5.0;
   cameraMaxFov = 65.0;
   
   throwForce = 30;

   aiAvoidThis = 1;

   minLookAngle = "-1.4";
   maxLookAngle = "0.9";
   maxFreelookAngle = 3.0;

   mass = 120;
   drag = 1.3;
   maxdrag = 0.4;
   density = 1.1;
   maxDamage = 10000;
   maxEnergy =  60;
   repairRate = 0.33;
   energyPerDamagePoint = 75;

   rechargeRate = 0.256;

   runForce = 4320;
   runEnergyDrain = 0;
   minRunEnergy = 0;
   maxForwardSpeed = 8;
   maxBackwardSpeed = 6;
   maxSideSpeed = 6;

   sprintForce = 4320;
   sprintEnergyDrain = 0;
   minSprintEnergy = 0;
   maxSprintForwardSpeed = 14;
   maxSprintBackwardSpeed = 8;
   maxSprintSideSpeed = 6;
   sprintStrafeScale = 0.25;
   sprintYawScale = 0.05;
   sprintPitchScale = 0.05;
   sprintCanJump = true;

   crouchForce = 405;
   maxCrouchForwardSpeed = 4.0;
   maxCrouchBackwardSpeed = 2.0;
   maxCrouchSideSpeed = 2.0;

   maxUnderwaterForwardSpeed = 8.4;
   maxUnderwaterBackwardSpeed = 7.8;
   maxUnderwaterSideSpeed = 4.0;

   jumpForce = "747";
   jumpEnergyDrain = 0;
   minJumpEnergy = 0;
   jumpDelay = "15";
   airControl = 0.3;

   fallingSpeedThreshold = -6.0;

   landSequenceTime = 0.33;
   transitionToLand = false;
   recoverDelay = 0;
   recoverRunForceScale = 0;

   minImpactSpeed = 10;
   minLateralImpactSpeed = 20;
   speedDamageScale = 0.4;

   boundingBox = "65 75 185";
   crouchBoundingBox = "0.65 0.75 1.3";
   swimBoundingBox = "1 2 2";
   pickupRadius = 1;

   // Damage location details
   boxHeadPercentage       = 0.83;
   boxTorsoPercentage      = 0.49;
   boxHeadLeftPercentage         = 0.30;
   boxHeadRightPercentage        = 0.60;
   boxHeadBackPercentage         = 0.30;
   boxHeadFrontPercentage        = 0.60;

   // Foot Prints
   decalOffset = 0.25;

   footPuffEmitter = "LightPuffEmitter";
   footPuffNumParts = 10;
   footPuffRadius = "0.25";

   dustEmitter = "LightPuffEmitter";

   splash = PlayerSplash;
   splashVelocity = 4.0;
   splashAngle = 67.0;
   splashFreqMod = 300.0;
   splashVelEpsilon = 0.60;
   bubbleEmitTime = 0.4;
   splashEmitter[0] = PlayerWakeEmitter;
   splashEmitter[1] = PlayerFoamEmitter;
   splashEmitter[2] = PlayerBubbleEmitter;
   mediumSplashSoundVelocity = 10.0;
   hardSplashSoundVelocity = 20.0;
   exitSplashSoundVelocity = 5.0;

   // Controls over slope of runnable/jumpable surfaces
   runSurfaceAngle  = 38;
   jumpSurfaceAngle = 80;
   maxStepHeight = 0.35;  //two meters
   minJumpSpeed = 20;
   maxJumpSpeed = 30;

   horizMaxSpeed = 68;
   horizResistSpeed = 33;
   horizResistFactor = 0.35;

   upMaxSpeed = 80;
   upResistSpeed = 25;
   upResistFactor = 0.3;

   footstepSplashHeight = 0.35;

   //NOTE:  some sounds commented out until wav's are available

   // Footstep Sounds
   FootSoftSound        = FootLightSoftSound;
   FootHardSound        = FootLightHardSound;
   FootMetalSound       = FootLightMetalSound;
   FootSnowSound        = FootLightSnowSound;
   FootShallowSound     = FootLightShallowSplashSound;
   FootWadingSound      = FootLightWadingSound;
   FootUnderwaterSound  = FootLightUnderwaterSound;
   
   groundImpactMinSpeed    = "45";
   groundImpactShakeFreq   = "4.0 4.0 4.0";
   groundImpactShakeAmp    = "1.0 1.0 1.0";
   groundImpactShakeDuration = 0.8;
   groundImpactShakeFalloff = 10.0;

   observeParameters = "0.5 4.5 4.5";
   class = "armor";

   cameraMinDist = "0";
   DecalData = "PlayerFootprint";

   // Allowable Inventory Items
   mainWeapon = basic;
   // Allowable Inventory Items
   maxInv[BulletAmmo] = 20;
   maxInv[HealthKit] = 1;
   maxInv[RifleAmmo] = 100;
   maxInv[basicAmmo] = 50;
   maxInv[basic] = 1;
   maxInv[Rifle] = 1;
   availableSkins =  "base	DarkBlue	DarkGreen	LightGreen	Orange	Red	Teal	Violet	Yellow";
   
   //Custom
   team = "FFA";
   moveSpeed = 1;
};
*/
//----------------------------------------------------------------------------
// Armor Datablock methods
//----------------------------------------------------------------------------

function Armor::onAdd(%this, %obj)
{
   // Vehicle timeout
   %obj.mountVehicle = true;

   // Default dynamic armor stats
   %obj.setRechargeRate(%this.rechargeRate);
   %obj.setRepairRate(0);

   // Set the numerical Health HUD
   //%obj.updateHealth();

   // Calling updateHealth() must be delayed now... for some reason
   %obj.schedule(50, "updateHealth");
}

function Armor::onRemove(%this, %obj)
{
   if (%obj.client.player == %obj)
      %obj.client.player = 0;
}

function Armor::onNewDataBlock(%this, %obj)
{
}

//----------------------------------------------------------------------------

function Armor::onMount(%this, %obj, %vehicle, %node)
{
   // Node 0 is the pilot's position, we need to dismount his weapon.
   if (%node == 0)
   {
      %obj.setTransform("0 0 0 0 0 1 0");
      %obj.setActionThread(%vehicle.getDatablock().mountPose[%node], true, true);

      %obj.lastWeapon = %obj.getMountedImage($WeaponSlot);
      %obj.unmountImage($WeaponSlot);

      %obj.setControlObject(%vehicle);
      
      if(%obj.getClassName() $= "Player")
         commandToClient(%obj.client, 'toggleVehicleMap', true);
   }
   else
   {
      if (%vehicle.getDataBlock().mountPose[%node] !$= "")
         %obj.setActionThread(%vehicle.getDatablock().mountPose[%node]);
      else
         %obj.setActionThread("root", true);
   }
}

function Armor::onUnmount(%this, %obj, %vehicle, %node)
{
   if (%node == 0)
   {
      %obj.mountImage(%obj.lastWeapon, $WeaponSlot);
      %obj.setControlObject("");
   }
}

function Armor::doDismount(%this, %obj, %forced)
{
   //echo("\c4Armor::doDismount(" @ %this @", "@ %obj.client.nameBase @", "@ %forced @")");

   // This function is called by player.cc when the jump trigger
   // is true while mounted
   %vehicle = %obj.mVehicle;
   if (!%obj.isMounted() || !isObject(%vehicle))
      return;

   // Vehicle must be at rest!
   if ((VectorLen(%vehicle.getVelocity()) <= %vehicle.getDataBlock().maxDismountSpeed ) || %forced)
   {
      // Position above dismount point
      %pos = getWords(%obj.getTransform(), 0, 2);
      %rot = getWords(%obj.getTransform(), 3, 6);
      %oldPos = %pos;
      %vec[0] = " -1 0 0";
      %vec[1] = " 0 0 1";
      %vec[2] = " 0 0 -1";
      %vec[3] = " 1 0 0";
      %vec[4] = "0 -1 0";
      %impulseVec = "0 0 0";
      %vec[0] = MatrixMulVector(%obj.getTransform(), %vec[0]);

      // Make sure the point is valid
      %pos = "0 0 0";
      %numAttempts = 5;
      %success = -1;
      for (%i = 0; %i < %numAttempts; %i++)
      {
         %pos = VectorAdd(%oldPos, VectorScale(%vec[%i], 3));
         if (%obj.checkDismountPoint(%oldPos, %pos))
         {
            %success = %i;
            %impulseVec = %vec[%i];
            break;
         }
      }
      if (%forced && %success == -1)
         %pos = %oldPos;

      %obj.mountVehicle = false;
      %obj.schedule(4000, "mountVehicles", true);

      // Position above dismount point
      %obj.unmount();
      %obj.setTransform(%pos SPC %rot);//%obj.setTransform(%pos);
      //%obj.playAudio(0, UnmountVehicleSound);
      %obj.applyImpulse(%pos, VectorScale(%impulseVec, %obj.getDataBlock().mass));

      // Set player velocity when ejecting
      %vel = %obj.getVelocity();
      %vec = vectorDot( %vel, vectorNormalize(%vel));
      if(%vec > 50)
      {
         %scale = 50 / %vec;
         %obj.setVelocity(VectorScale(%vel, %scale));
      }

      //%obj.vehicleTurret = "";
   }
   else
      messageClient(%obj.client, 'msgUnmount', '\c2Cannot exit %1 while moving.', %vehicle.getDataBlock().nameTag);
}

//----------------------------------------------------------------------------

function Armor::onCollision(%this, %obj, %col)
{
   if (!isObject(%col) || %obj.getState() $= "Dead")
      return;

   // Try and pickup all items
   if (%col.getClassName() $= "Item")
   {
      %obj.pickup(%col);
      return;
   }

   // Mount vehicles
   if (%col.getType() & $TypeMasks::GameBaseObjectType)
   {
      %db = %col.getDataBlock();
      if ((%db.getClassName() $= "WheeledVehicleData" ) && %obj.mountVehicle && %obj.getState() $= "Move" && %col.mountable)
      {
         // Only mount drivers for now.
         ServerConnection.setFirstPerson(0);
         
         // For this specific example, only one person can fit
         // into a vehicle
         %mount = %col.getMountNodeObject(0);         
         if(%mount)
            return;
         
         // For this specific FPS Example, always mount the player
         // to node 0
         %node = 0;
         %col.mountObject(%obj, %node);
         %obj.mVehicle = %col;
      }
   }
}

function Armor::onImpact(%this, %obj, %collidedObject, %vec, %vecLen)
{
   %obj.damage(0, VectorAdd(%obj.getPosition(), %vec), %vecLen * %this.speedDamageScale, "Impact");
}

//----------------------------------------------------------------------------

function Armor::damage(%this, %obj, %sourceObject, %position, %damage, %damageType)
{
   if(!%obj.isMethod("getState"))
   { 
      if(%obj.dataBlock.isMethod("getState"))
         %state = %obj.dataBlock.getState();  
   }
   else
      %state = %obj.getState();
   if (!isObject(%obj) || %state $= "Dead" || !%damage)
      return;

   %obj.applyDamage(%damage);

   %location = "Body";

   // Update the numerical Health HUD
   %obj.updateHealth();

    // Deal with client callbacks here because we don't have this
   // information in the onDamage or onDisable methods
   %client = %obj.client;
   %sourceClient = %sourceObject ? %sourceObject.client : 0;
   if (%obj.isbot == true)
   {
    %obj.enhancefov(%obj);
   }

   if (%obj.getState() $= "Dead")
   {
      if (%obj.isbot == true)
      {
         /*if (%obj.respawn == true)
         {
            AIPlayer::delaybeforerespawn(%obj, %obj.botname, %obj.spawnPos);
         }*/
      }
      else
      {
         // Determine damage direction
         if (isObject(%client))
         {
            if (%damageType !$= "Suicide")
               %obj.setDamageDirection(%sourceObject, %position);
         }
         %client.onDeath(%sourceObject, %sourceClient, %damageType, %location);
      }
   }
   if (isObject(%client))
   {
      // Determine damage direction
      if (%damageType !$= "Suicide")
         %obj.setDamageDirection(%sourceObject, %position);
   }
}

function Armor::onDamage(%this, %obj, %delta)
{
   // This method is invoked by the ShapeBase code whenever the
   // object's damage level changes.
   if (%delta > 0 && %obj.getState() !$= "Dead")
   {
      // Apply a damage flash
      %obj.setDamageFlash(1);

      // If the pain is excessive, let's hear about it.
      if (%delta > 10)
         %obj.playPain();
   }
}

// ----------------------------------------------------------------------------
// The player object sets the "disabled" state when damage exceeds it's
// maxDamage value. This is method is invoked by ShapeBase state mangement code.

// If we want to deal with the damage information that actually caused this
// death, then we would have to move this code into the script "damage" method.

function Armor::onDisabled(%this, %obj, %state)
{
   // Release the main weapon trigger
   %obj.setImageTrigger(0, false);

   // Toss current mounted weapon and ammo if any
   %item = %obj.getMountedImage($WeaponSlot).item;
   if (isObject(%item))
   {
      %amount = %obj.getInventory(%item.image.ammo);
      
      if (!%item.image.clip)
         warn("No clip exists to throw for item ", %item);
      if(%amount)
         %obj.throw(%item.image.clip, 1);
   }

   // Toss out a health patch
   //%obj.tossPatch();

   %obj.playDeathCry();
   %obj.playDeathAnimation();
   //%obj.setDamageFlash(0.75);

   // Disable any vehicle map
   commandToClient(%obj.client, 'toggleVehicleMap', false);

   // Schedule corpse removal. Just keeping the place clean.
   %obj.schedule($CorpseTimeoutValue - 1000, "startFade", 1000, 0, true);
   %obj.schedule($CorpseTimeoutValue, "delete");
}

//-----------------------------------------------------------------------------

function Armor::onLeaveMissionArea(%this, %obj)
{
   //echo("\c4Leaving Mission Area at POS:"@ %obj.getPosition());

   // Inform the client
   %obj.client.onLeaveMissionArea();

   // Damage over time and kill the coward!
   //%obj.setDamageDt(0.2, "MissionAreaDamage");
}

function Armor::onEnterMissionArea(%this, %obj)
{
   //echo("\c4Entering Mission Area at POS:"@ %obj.getPosition());

   // Inform the client
   %obj.client.onEnterMissionArea();

   // Stop the punishment
   //%obj.clearDamageDt();
}

//-----------------------------------------------------------------------------

function Armor::onEnterLiquid(%this, %obj, %coverage, %type)
{
   //echo("\c4this:"@ %this @" object:"@ %obj @" just entered water of type:"@ %type @" for "@ %coverage @"coverage");
}

function Armor::onLeaveLiquid(%this, %obj, %type)
{
   //
}

//-----------------------------------------------------------------------------

function Armor::onTrigger(%this, %obj, %triggerNum, %val)
{
   // This method is invoked when the player receives a trigger move event.
   // The player automatically triggers slot 0 and slot one off of triggers #
   // 0 & 1.  Trigger # 2 is also used as the jump key.
}

//-----------------------------------------------------------------------------

function Armor::onPoseChange(%this, %obj, %oldPose, %newPose)
{
   // Set the script anim prefix to be that of the current pose
   %obj.setImageScriptAnimPrefix( $WeaponSlot, addTaggedString(%newPose) );
}

//-----------------------------------------------------------------------------

function Armor::onStartSprintMotion(%this, %obj)
{
   %obj.setImageGenericTrigger($WeaponSlot, 0, true);
}

function Armor::onStopSprintMotion(%this, %obj)
{
   %obj.setImageGenericTrigger($WeaponSlot, 0, false);
}

//-----------------------------------------------------------------------------
// Player methods
//-----------------------------------------------------------------------------

//----------------------------------------------------------------------------

function Player::kill(%this, %damageType)
{
   %this.damage(0, %this.getPosition(), 10000, %damageType);
}

//----------------------------------------------------------------------------

function Player::mountVehicles(%this, %bool)
{
   // If set to false, this variable disables vehicle mounting.
   %this.mountVehicle = %bool;
}

function Player::isPilot(%this)
{
   %vehicle = %this.getObjectMount();
   // There are two "if" statements to avoid a script warning.
   if (%vehicle)
      if (%vehicle.getMountNodeObject(0) == %this)
         return true;
   return false;
}

//----------------------------------------------------------------------------

function Player::playDeathAnimation(%this)
{
   %numDeathAnimations = %this.getNumDeathAnimations();
   if ( %numDeathAnimations > 0 )
   {
      if (isObject(%this.client))
      {
         if (%this.client.deathIdx++ > %numDeathAnimations)
            %this.client.deathIdx = 1;
         %this.setActionThread("Death" @ %this.client.deathIdx);
      }
      else
      {
         %rand = getRandom(1, %numDeathAnimations);
         %this.setActionThread("Death" @ %rand);
      }
   }
}

function Player::playCelAnimation(%this, %anim)
{
   if (%this.getState() !$= "Dead")
      %this.setActionThread("cel"@%anim);
}

function Player::playSpellAnimation(%this, %anim)
{
   if (%this.getState() !$= "Dead")
      %this.setActionThread("spell_"@%anim);
}


//----------------------------------------------------------------------------

function Player::playDeathCry(%this)
{
   %this.playAudio(0, DeathCrySound);
}

function Player::playPain(%this)
{
   %this.playAudio(0, PainCrySound);
}

// ----------------------------------------------------------------------------
// Numerical Health Counter
// ----------------------------------------------------------------------------

function Player::updateHealth(%player)
{
   //echo("\c4Player::updateHealth() -> Player Health changed, updating HUD!");

   // Calcualte player health
   %maxDamage = %player.getDatablock().maxDamage;
   %damageLevel = %player.getDamageLevel();
   %curHealth = %maxDamage - %damageLevel;
   %curHealth = mceil(%curHealth);

   // Send the player object's current health level to the client, where it
   // will Update the numericalHealth HUD.
   commandToClient(%player.client, 'setNumericalHealthHUD', %curHealth);
}

function Player::setDamageDirection(%player, %sourceObject, %damagePos)
{
   if (isObject(%sourceObject))
   {
      if (%sourceObject.isField(initialPosition))
      {
         // Projectiles have this field set to the muzzle point of
         // the firing weapon at the time the projectile was created.
         // This gives a damage direction towards the firing player,
         // turret, vehicle, etc.  Bullets and weapon fired grenades
         // are examples of projectiles.
         %damagePos = %sourceObject.initialPosition;
      }
      else
      {
         // Other objects that cause damage, such as mines, use their own
         // location as the damage position.  This gives a damage direction
         // towards the explosive origin rather than the person that lay the
         // explosives.
         %damagePos = %sourceObject.getPosition();
      }
   }

   // Rotate damage vector into object space
   %damageVec = VectorSub(%damagePos, %player.getWorldBoxCenter());
   %damageVec = VectorNormalize(%damageVec);
   %damageVec = MatrixMulVector(%player.client.getCameraObject().getInverseTransform(), %damageVec);

   // Determine largest component of damage vector to get direction
   %vecComponents = -%damageVec.x SPC %damageVec.x SPC -%damageVec.y SPC %damageVec.y SPC -%damageVec.z SPC %damageVec.z;
   %vecDirections = "Left"        SPC "Right"      SPC "Bottom"      SPC "Front"      SPC "Bottom"      SPC "Top";

   %max = -1;
   for (%i = 0; %i < 6; %i++)
   {
      %value = getWord(%vecComponents, %i);
      if (%value > %max)
      {
         %max = %value;
         %damageDir = getWord(%vecDirections, %i);
      }
   }
   commandToClient(%player.client, 'setDamageDirection', %damageDir);
}

function Player::use(%player, %data)
{
   // No mounting/using weapons when you're driving!
   if (%player.isPilot())
      return(false);

   Parent::use(%player, %data);
}

datablock PlayerData(DefaultPlayerData)
{
   pickupRadius = "75";
   renderFirstPerson = "0";
   maxLookAngle = "0.9";
   maxStepHeight = "0.35";
   runForce = "4320";
   maxForwardSpeed = "8";
   maxBackwardSpeed = "6";
   maxSideSpeed = "6";
   runSurfaceAngle = "38";
   minImpactSpeed = "10";
   minLateralImpactSpeed = "20";
   horizMaxSpeed = "68";
   horizResistSpeed = "33";
   horizResistFactor = "0.35";
   upResistSpeed = "25";
   upResistFactor = "0.3";
   jumpForce = "747";
   minJumpSpeed = "20";
   maxJumpSpeed = "30";
   jumpSurfaceAngle = "80";
   jumpDelay = "15";
   airControl = "0.3";
   sprintForce = "4320";
   maxSprintForwardSpeed = "14";
   maxSprintBackwardSpeed = "8";
   maxSprintSideSpeed = "6";
   sprintStrafeScale = "0.25";
   sprintYawScale = "0.05";
   sprintPitchScale = "0.05";
   maxUnderwaterForwardSpeed = "8.4";
   maxUnderwaterBackwardSpeed = "7.8";
   maxUnderwaterSideSpeed = "4";
   maxCrouchBackwardSpeed = "2";
   maxCrouchSideSpeed = "2";
   fallingSpeedThreshold = "-6";
   recoverDelay = "0";
   recoverRunForceScale = "0";
   landSequenceTime = "0.33";
   boundingBox = "0.65 0.75 1.85";
   crouchBoundingBox = "0.65 0.75 1.3";
   swimBoundingBox = "1 2 2";
   boxHeadPercentage = "0.83";
   boxTorsoPercentage = "0.49";
   boxHeadLeftPercentage = "0.3";
   boxHeadRightPercentage = "0.6";
   boxHeadBackPercentage = "0.3";
   boxHeadFrontPercentage = "0.6";
   footPuffNumParts = "10";
   decalOffset = "0.25";
   splashVelocity = "4";
   splashAngle = "67";
   splashVelEpsilon = "0.6";
   footstepSplashHeight = "0.35";
   mediumSplashSoundVelocity = "10";
   hardSplashSoundVelocity = "20";
   exitSplashSoundVelocity = "5";
   groundImpactMinSpeed = "45";
   groundImpactShakeFreq = "4 4 4";
   groundImpactShakeAmp = "1 1 1";
   groundImpactShakeDuration = "0.8";
   allowImageStateAnimation = "1";
   shapeFile = "art/shapes/actors/Soldier/soldier_rigged.dae";
   mass = "120";
   drag = "1.3";
   maxDamage = "10000";
   repairRate = "0.33";
   cameraMaxDist = "5";
   cameraMinDist = "0";
   cameraDefaultFov = "55";
   cameraMaxFov = "65";
   useEyePoint = "1";
   class = "armor";
   maxInvbasicAmmo = "50";
   maxInvBulletAmmo = "20";
   canObserve = "1";
   energyPerDamagePoint = "75";
   team = "FFA";
   maxInvbasic = "1";
   maxInvHealthKit = "1";
   availableSkins = "base	DarkBlue	DarkGreen	LightGreen	Orange	Red	Teal	Violet	Yellow";
   cmdCategory = "Clients";
   maxDrag = "0.4";
   maxInvRifle = "1";
   observeParameters = "0.5 4.5 4.5";
   rechargeRate = "0.256";
   maxInvRifleAmmo = "100";
   throwForce = "30";
   moveSpeed = "1";
   mainWeapon = "basic";
   speedDamageScale = "0.4";
   aiAvoidThis = "1";
   observeThroughObject = "1";
};