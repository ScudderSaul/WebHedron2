 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
   public class HedronList
    {
       List<HedronBase> _hedronlist = new List<HedronBase>();

       public HedronList()
       {
                  _hedronlist.Add(new AcuteGoldenRhombohedronHedron());
        _hedronlist.Add(new AntiprismHedron());
        _hedronlist.Add(new Antiprism2Hedron());
        _hedronlist.Add(new Antiprism3Hedron());
        _hedronlist.Add(new Antiprism4Hedron());
        _hedronlist.Add(new Antiprism5Hedron());
        _hedronlist.Add(new Antiprism6Hedron());
        _hedronlist.Add(new Antiprism7Hedron());
        _hedronlist.Add(new Antiprism8Hedron());
        _hedronlist.Add(new AugmentedDodecahedronHedron());
        _hedronlist.Add(new AugmentedHexagonalPrismHedron());
        _hedronlist.Add(new AugmentedPentagonalPrismHedron());
        _hedronlist.Add(new AugmentedSphenocoronaHedron());
        _hedronlist.Add(new AugmentedTriangularPrismHedron());
        _hedronlist.Add(new AugmentedTridiminishedIcosahedronHedron());
        _hedronlist.Add(new AugmentedTruncatedCubeHedron());
        _hedronlist.Add(new AugmentedTruncatedDodecahedronHedron());
        _hedronlist.Add(new AugmentedTruncatedTetrahedronHedron());
        _hedronlist.Add(new BiaugmentedPentagonalPrismHedron());
        _hedronlist.Add(new BiaugmentedTriangularPrismHedron());
        _hedronlist.Add(new BiaugmentedTruncatedCubeHedron());
        _hedronlist.Add(new BigyrateDiminishedRhombicosidodecahedronHedron());
        _hedronlist.Add(new BilunabirotundaHedron());
        _hedronlist.Add(new CsaszarPolyhedronHedron());
        _hedronlist.Add(new CubeHedron());
        _hedronlist.Add(new CubeFiveCompoundHedron());
        _hedronlist.Add(new CubeFourCompoundHedron());
        _hedronlist.Add(new CubeFourCompound26Hedron());
        _hedronlist.Add(new CubeFourCompound27Hedron());
        _hedronlist.Add(new CubeOctahedronCompoundHedron());
        _hedronlist.Add(new CubeOctahedronFiveCompoundHedron());
        _hedronlist.Add(new CubeOctahedronThreeCompoundHedron());
        _hedronlist.Add(new CubeSixCompoundHedron());
        _hedronlist.Add(new CubeTenCompoundHedron());
        _hedronlist.Add(new CubeThreeCompoundHedron());
        _hedronlist.Add(new CubeTwoCompoundHedron());
        _hedronlist.Add(new CuboctahedronHedron());
        _hedronlist.Add(new CumulatedCubeHedron());
        _hedronlist.Add(new CumulatedDodecahedronHedron());
        _hedronlist.Add(new CumulatedTetrahedronHedron());
        _hedronlist.Add(new DeltoidalHexecontahedronHedron());
        _hedronlist.Add(new DeltoidalIcositetrahedronHedron());
        _hedronlist.Add(new DiminishedRhombicosidodecahedronHedron());
        _hedronlist.Add(new DipyramidHedron());
        _hedronlist.Add(new Dipyramid42Hedron());
        _hedronlist.Add(new Dipyramid43Hedron());
        _hedronlist.Add(new DisdyakisDodecahedronHedron());
        _hedronlist.Add(new DisdyakisTriacontahedronHedron());
        _hedronlist.Add(new DisphenocingulumHedron());
        _hedronlist.Add(new DodecahedronHedron());
        _hedronlist.Add(new DodecahedronFiveCompoundHedron());
        _hedronlist.Add(new DodecahedronIcosahedronCompoundHedron());
        _hedronlist.Add(new DodecahedronSixCompoundHedron());
        _hedronlist.Add(new DodecahedronSmallTriambicIcosahedronCompoundHedron());
        _hedronlist.Add(new DodecahedronTwoCompoundHedron());
        _hedronlist.Add(new DuerersSolidHedron());
        _hedronlist.Add(new EchidnahedronHedron());
        _hedronlist.Add(new ElongatedDodecahedronHedron());
        _hedronlist.Add(new ElongatedPentagonalCupolaHedron());
        _hedronlist.Add(new ElongatedPentagonalDipyramidHedron());
        _hedronlist.Add(new ElongatedPentagonalGyrobicupolaHedron());
        _hedronlist.Add(new ElongatedPentagonalGyrobirotundaHedron());
        _hedronlist.Add(new ElongatedPentagonalGyrocupolarotundaHedron());
        _hedronlist.Add(new ElongatedPentagonalOrthobicupolaHedron());
        _hedronlist.Add(new ElongatedPentagonalOrthobirotundaHedron());
        _hedronlist.Add(new ElongatedPentagonalOrthocupolarotundaHedron());
        _hedronlist.Add(new ElongatedPentagonalPyramidHedron());
        _hedronlist.Add(new ElongatedPentagonalRotundaHedron());
        _hedronlist.Add(new ElongatedSquareCupolaHedron());
        _hedronlist.Add(new ElongatedSquareDipyramidHedron());
        _hedronlist.Add(new ElongatedSquareGyrobicupolaHedron());
        _hedronlist.Add(new ElongatedSquarePyramidHedron());
        _hedronlist.Add(new ElongatedTriangularCupolaHedron());
        _hedronlist.Add(new ElongatedTriangularDipyramidHedron());
        _hedronlist.Add(new ElongatedTriangularGyrobicupolaHedron());
        _hedronlist.Add(new ElongatedTriangularOrthobicupolaHedron());
        _hedronlist.Add(new ElongatedTriangularPyramidHedron());
        _hedronlist.Add(new EschersSolidHedron());
        _hedronlist.Add(new GreatDodecahedronHedron());
        _hedronlist.Add(new GreatIcosahedronHedron());
        _hedronlist.Add(new GreatRhombicosidodecahedronHedron());
        _hedronlist.Add(new GreatRhombicTriacontahedronHedron());
        _hedronlist.Add(new GreatRhombicuboctahedronHedron());
        _hedronlist.Add(new GreatStellatedDodecahedronHedron());
        _hedronlist.Add(new GyrateBidiminishedRhombicosidodecahedronHedron());
        _hedronlist.Add(new GyrateRhombicosidodecahedronHedron());
        _hedronlist.Add(new GyrobifastigiumHedron());
        _hedronlist.Add(new GyroelongatedPentagonalBicupolaHedron());
        _hedronlist.Add(new GyroelongatedPentagonalBirotundaHedron());
        _hedronlist.Add(new GyroelongatedPentagonalCupolaHedron());
        _hedronlist.Add(new GyroelongatedPentagonalCupolarotundaHedron());
        _hedronlist.Add(new GyroelongatedPentagonalPyramidHedron());
        _hedronlist.Add(new GyroelongatedPentagonalRotundaHedron());
        _hedronlist.Add(new GyroelongatedSquareBicupolaHedron());
        _hedronlist.Add(new GyroelongatedSquareCupolaHedron());
        _hedronlist.Add(new GyroelongatedSquareDipyramidHedron());
        _hedronlist.Add(new GyroelongatedSquarePyramidHedron());
        _hedronlist.Add(new GyroelongatedTriangularBicupolaHedron());
        _hedronlist.Add(new GyroelongatedTriangularCupolaHedron());
        _hedronlist.Add(new HebesphenomegacoronaHedron());
        _hedronlist.Add(new IcosahedronHedron());
        _hedronlist.Add(new IcosahedronFiveCompoundHedron());
        _hedronlist.Add(new IcosahedronSixCompoundHedron());
        _hedronlist.Add(new IcosahedronTwoCompoundHedron());
        _hedronlist.Add(new IcosidodecahedronHedron());
        _hedronlist.Add(new JessensOrthogonalIcosahedronHedron());
        _hedronlist.Add(new MathematicaPolyhedronHedron());
        _hedronlist.Add(new MetabiaugmentedDodecahedronHedron());
        _hedronlist.Add(new MetabiaugmentedHexagonalPrismHedron());
        _hedronlist.Add(new MetabiaugmentedTruncatedDodecahedronHedron());
        _hedronlist.Add(new MetabidiminishedIcosahedronHedron());
        _hedronlist.Add(new MetabidiminishedRhombicosidodecahedronHedron());
        _hedronlist.Add(new MetabigyrateRhombicosidodecahedronHedron());
        _hedronlist.Add(new MetagyrateDiminishedRhombicosidodecahedronHedron());
        _hedronlist.Add(new ObtuseGoldenRhombohedronHedron());
        _hedronlist.Add(new OctahedronHedron());
        _hedronlist.Add(new OctahedronFiveCompoundHedron());
        _hedronlist.Add(new OctahedronFourCompoundHedron());
        _hedronlist.Add(new OctahedronFourCompound115Hedron());
        _hedronlist.Add(new OctahedronFourCompound116Hedron());
        _hedronlist.Add(new OctahedronTenCompoundHedron());
        _hedronlist.Add(new OctahedronThreeCompoundHedron());
        _hedronlist.Add(new ParabiaugmentedDodecahedronHedron());
        _hedronlist.Add(new ParabiaugmentedHexagonalPrismHedron());
        _hedronlist.Add(new ParabiaugmentedTruncatedDodecahedronHedron());
        _hedronlist.Add(new ParabidiminishedRhombicosidodecahedronHedron());
        _hedronlist.Add(new ParabigyrateRhombicosidodecahedronHedron());
        _hedronlist.Add(new ParagyrateDiminishedRhombicosidodecahedronHedron());
        _hedronlist.Add(new PentagonalCupolaHedron());
        _hedronlist.Add(new PentagonalGyrobicupolaHedron());
        _hedronlist.Add(new PentagonalGyrocupolarotundaHedron());
        _hedronlist.Add(new PentagonalHexecontahedronHedron());
        _hedronlist.Add(new PentagonalIcositetrahedronHedron());
        _hedronlist.Add(new PentagonalOrthobicupolaHedron());
        _hedronlist.Add(new PentagonalOrthobirotundaHedron());
        _hedronlist.Add(new PentagonalOrthocupolarotundaHedron());
        _hedronlist.Add(new PentagonalPrismSixCompoundHedron());
        _hedronlist.Add(new PentagonalRotundaHedron());
        _hedronlist.Add(new PentakisDodecahedronHedron());
        _hedronlist.Add(new PrismHedron());
        _hedronlist.Add(new Prism136Hedron());
        _hedronlist.Add(new Prism137Hedron());
        _hedronlist.Add(new Prism138Hedron());
        _hedronlist.Add(new Prism139Hedron());
        _hedronlist.Add(new Prism140Hedron());
        _hedronlist.Add(new Prism141Hedron());
        _hedronlist.Add(new Prism142Hedron());
        _hedronlist.Add(new PyramidHedron());
        _hedronlist.Add(new Pyramid143Hedron());
        _hedronlist.Add(new Pyramid144Hedron());
        _hedronlist.Add(new RhombicDodecahedronHedron());
        _hedronlist.Add(new RhombicDodecahedronStellationHedron());
        _hedronlist.Add(new RhombicDodecahedronStellation146Hedron());
        _hedronlist.Add(new RhombicDodecahedronStellation147Hedron());
        _hedronlist.Add(new RhombicEnneacontahedronHedron());
        _hedronlist.Add(new RhombicHexecontahedronHedron());
        _hedronlist.Add(new RhombicIcosahedronHedron());
        _hedronlist.Add(new RhombicTriacontahedronHedron());
        _hedronlist.Add(new SmallRhombicosidodecahedronHedron());
        _hedronlist.Add(new SmallRhombicuboctahedronHedron());
        _hedronlist.Add(new SmallStellatedDodecahedronHedron());
        _hedronlist.Add(new SmallTriakisOctahedronHedron());
        _hedronlist.Add(new SmallTriambicIcosahedronHedron());
        _hedronlist.Add(new SnubCubeHedron());
        _hedronlist.Add(new SnubDisphenoidHedron());
        _hedronlist.Add(new SnubDodecahedronHedron());
        _hedronlist.Add(new SnubSquareAntiprismHedron());
        _hedronlist.Add(new SphenocoronaHedron());
        _hedronlist.Add(new SphenomegacoronaHedron());
        _hedronlist.Add(new SquareCupolaHedron());
        _hedronlist.Add(new SquareGyrobicupolaHedron());
        _hedronlist.Add(new SquareOrthobicupolaHedron());
        _hedronlist.Add(new SquashedDodecahedronHedron());
        _hedronlist.Add(new StellaOctangulaHedron());
        _hedronlist.Add(new SzilassiPolyhedronHedron());
        _hedronlist.Add(new TetrahedronHedron());
        _hedronlist.Add(new TetrahedronFiveCompoundHedron());
        _hedronlist.Add(new TetrahedronFourCompoundHedron());
        _hedronlist.Add(new TetrahedronFourCompound171Hedron());
        _hedronlist.Add(new TetrahedronFourCompound172Hedron());
        _hedronlist.Add(new TetrahedronFourCompound173Hedron());
        _hedronlist.Add(new TetrahedronSixCompoundHedron());
        _hedronlist.Add(new TetrahedronTenCompoundHedron());
        _hedronlist.Add(new TetrahedronThreeCompoundHedron());
        _hedronlist.Add(new TetrahedronTwoCompoundHedron());
        _hedronlist.Add(new TetrakisHexahedronHedron());
        _hedronlist.Add(new TriakisIcosahedronHedron());
        _hedronlist.Add(new TriakisTetrahedronHedron());
        _hedronlist.Add(new TriangularCupolaHedron());
        _hedronlist.Add(new TriangularHebesphenorotundaHedron());
        _hedronlist.Add(new TriangularOrthobicupolaHedron());
        _hedronlist.Add(new TriaugmentedDodecahedronHedron());
        _hedronlist.Add(new TriaugmentedHexagonalPrismHedron());
        _hedronlist.Add(new TriaugmentedTriangularPrismHedron());
        _hedronlist.Add(new TriaugmentedTruncatedDodecahedronHedron());
        _hedronlist.Add(new TridiminishedIcosahedronHedron());
        _hedronlist.Add(new TridiminishedRhombicosidodecahedronHedron());
        _hedronlist.Add(new TrigyrateRhombicosidodecahedronHedron());
        _hedronlist.Add(new TruncatedCubeHedron());
        _hedronlist.Add(new TruncatedDodecahedronHedron());
        _hedronlist.Add(new TruncatedIcosahedronHedron());
        _hedronlist.Add(new TruncatedOctahedronHedron());
        _hedronlist.Add(new TruncatedTetrahedronHedron());

       }

      public List<HedronBase> FullList
       {
           get { return _hedronlist; }
       } 

    }
}