 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedronClasses
{
    class GreatRhombicTriacontahedronHedron : HedronBase
    {
       public GreatRhombicTriacontahedronHedron()
       {
                   Name = "GreatRhombicTriacontahedron";

         Vertex.Add(0, new HVector(-6.13049516849971, 0, -1.17082039324994));
         Vertex.Add(1, new HVector(-4.95967477524977, -3.60341464929439, 1.17082039324994));
         Vertex.Add(2, new HVector(-4.95967477524977, 3.60341464929439, 1.17082039324994));
         Vertex.Add(3, new HVector(-4.23606797749979, -1.37638192047117, 0));
         Vertex.Add(4, new HVector(-4.23606797749979, 1.37638192047117, 0));
         Vertex.Add(5, new HVector(-3.78885438199983, 0, -4.95967477524977));
         Vertex.Add(6, new HVector(-3.78885438199983, 0, -2.34164078649987));
         Vertex.Add(7, new HVector(-3.78885438199983, 0, 0.276393202250021));
         Vertex.Add(8, new HVector(-3.78885438199983, 0, 1.89442719099992));
         Vertex.Add(9, new HVector(-3.51246117974981, -0.85065080835204, -1.17082039324994));
         Vertex.Add(10, new HVector(-3.51246117974981, 0.85065080835204, -1.17082039324994));
         Vertex.Add(11, new HVector(-3.34164078649987, -1.37638192047117, 1.17082039324994));
         Vertex.Add(12, new HVector(-3.34164078649987, 1.37638192047117, 1.17082039324994));
         Vertex.Add(13, new HVector(-3.06524758424985, -2.22703272882321, -1.89442719099992));
         Vertex.Add(14, new HVector(-3.06524758424985, -2.22703272882321, -0.276393202250021));
         Vertex.Add(15, new HVector(-3.06524758424985, -2.22703272882321, 2.34164078649987));
         Vertex.Add(16, new HVector(-3.06524758424985, -2.22703272882321, 4.95967477524977));
         Vertex.Add(17, new HVector(-3.06524758424985, -0.525731112119134, 0.723606797749979));
         Vertex.Add(18, new HVector(-3.06524758424985, 0.525731112119134, 0.723606797749979));
         Vertex.Add(19, new HVector(-3.06524758424985, 2.22703272882321, -1.89442719099992));
         Vertex.Add(20, new HVector(-3.06524758424985, 2.22703272882321, -0.276393202250021));
         Vertex.Add(21, new HVector(-3.06524758424985, 2.22703272882321, 2.34164078649987));
         Vertex.Add(22, new HVector(-3.06524758424985, 2.22703272882321, 4.95967477524977));
         Vertex.Add(23, new HVector(-2.78885438199983, -1.37638192047117, -0.723606797749979));
         Vertex.Add(24, new HVector(-2.78885438199983, 1.37638192047117, -0.723606797749979));
         Vertex.Add(25, new HVector(-2.61803398874989, -3.60341464929439, 0));
         Vertex.Add(26, new HVector(-2.61803398874989, -0.85065080835204, -2.61803398874989));
         Vertex.Add(27, new HVector(-2.61803398874989, -0.85065080835204, -1.61803398874989));
         Vertex.Add(28, new HVector(-2.61803398874989, -0.85065080835204, 1.61803398874989));
         Vertex.Add(29, new HVector(-2.61803398874989, -0.85065080835204, 2.61803398874989));
         Vertex.Add(30, new HVector(-2.61803398874989, 0.85065080835204, -2.61803398874989));
         Vertex.Add(31, new HVector(-2.61803398874989, 0.85065080835204, -1.61803398874989));
         Vertex.Add(32, new HVector(-2.61803398874989, 0.85065080835204, 1.61803398874989));
         Vertex.Add(33, new HVector(-2.61803398874989, 0.85065080835204, 2.61803398874989));
         Vertex.Add(34, new HVector(-2.61803398874989, 3.60341464929439, 0));
         Vertex.Add(35, new HVector(-2.34164078649987, -2.75276384094235, 1.17082039324994));
         Vertex.Add(36, new HVector(-2.34164078649987, 0, 2.17082039324994));
         Vertex.Add(37, new HVector(-2.34164078649987, 0, 3.78885438199983));
         Vertex.Add(38, new HVector(-2.34164078649987, 2.75276384094235, 1.17082039324994));
         Vertex.Add(39, new HVector(-2.17082039324994, -2.22703272882321, -0.723606797749979));
         Vertex.Add(40, new HVector(-2.17082039324994, 2.22703272882321, -0.723606797749979));
         Vertex.Add(41, new HVector(-1.89442719099992, -5.8304473781176, -1.17082039324994));
         Vertex.Add(42, new HVector(-1.89442719099992, -3.07768353717525, -1.17082039324994));
         Vertex.Add(43, new HVector(-1.89442719099992, -1.37638192047117, -3.78885438199983));
         Vertex.Add(44, new HVector(-1.89442719099992, -1.37638192047117, -2.17082039324994));
         Vertex.Add(45, new HVector(-1.89442719099992, 1.37638192047117, -3.78885438199983));
         Vertex.Add(46, new HVector(-1.89442719099992, 1.37638192047117, -2.17082039324994));
         Vertex.Add(47, new HVector(-1.89442719099992, 3.07768353717525, -1.17082039324994));
         Vertex.Add(48, new HVector(-1.89442719099992, 5.8304473781176, -1.17082039324994));
         Vertex.Add(49, new HVector(-1.61803398874989, -2.22703272882321, -2.61803398874989));
         Vertex.Add(50, new HVector(-1.61803398874989, -2.22703272882321, -1.61803398874989));
         Vertex.Add(51, new HVector(-1.61803398874989, -2.22703272882321, 1.61803398874989));
         Vertex.Add(52, new HVector(-1.61803398874989, -2.22703272882321, 2.61803398874989));
         Vertex.Add(53, new HVector(-1.61803398874989, 2.22703272882321, -2.61803398874989));
         Vertex.Add(54, new HVector(-1.61803398874989, 2.22703272882321, -1.61803398874989));
         Vertex.Add(55, new HVector(-1.61803398874989, 2.22703272882321, 1.61803398874989));
         Vertex.Add(56, new HVector(-1.61803398874989, 2.22703272882321, 2.61803398874989));
         Vertex.Add(57, new HVector(-1.44721359549996, -2.75276384094235, 0.723606797749979));
         Vertex.Add(58, new HVector(-1.44721359549996, 0, -3.51246117974981));
         Vertex.Add(59, new HVector(-1.44721359549996, 2.75276384094235, 0.723606797749979));
         Vertex.Add(60, new HVector(-1.17082039324994, -3.60341464929439, -4.95967477524977));
         Vertex.Add(61, new HVector(-1.17082039324994, -3.60341464929439, -2.34164078649987));
         Vertex.Add(62, new HVector(-1.17082039324994, -3.60341464929439, 0.276393202250021));
         Vertex.Add(63, new HVector(-1.17082039324994, -3.60341464929439, 1.89442719099992));
         Vertex.Add(64, new HVector(-1.17082039324994, -0.85065080835204, 3.51246117974981));
         Vertex.Add(65, new HVector(-1.17082039324994, 0.85065080835204, 3.51246117974981));
         Vertex.Add(66, new HVector(-1.17082039324994, 3.60341464929439, -4.95967477524977));
         Vertex.Add(67, new HVector(-1.17082039324994, 3.60341464929439, -2.34164078649987));
         Vertex.Add(68, new HVector(-1.17082039324994, 3.60341464929439, 0.276393202250021));
         Vertex.Add(69, new HVector(-1.17082039324994, 3.60341464929439, 1.89442719099992));
         Vertex.Add(70, new HVector(-0.894427190999916, 0, 3.06524758424985));
         Vertex.Add(71, new HVector(-0.723606797749979, -2.22703272882321, 2.17082039324994));
         Vertex.Add(72, new HVector(-0.723606797749979, -2.22703272882321, 3.78885438199983));
         Vertex.Add(73, new HVector(-0.723606797749979, -0.525731112119134, -3.06524758424985));
         Vertex.Add(74, new HVector(-0.723606797749979, 0.525731112119134, -3.06524758424985));
         Vertex.Add(75, new HVector(-0.723606797749979, 2.22703272882321, 2.17082039324994));
         Vertex.Add(76, new HVector(-0.723606797749979, 2.22703272882321, 3.78885438199983));
         Vertex.Add(77, new HVector(-0.447213595499958, -3.07768353717525, 0.723606797749979));
         Vertex.Add(78, new HVector(-0.447213595499958, -1.37638192047117, -3.51246117974981));
         Vertex.Add(79, new HVector(-0.447213595499958, 1.37638192047117, -3.51246117974981));
         Vertex.Add(80, new HVector(-0.447213595499958, 3.07768353717525, 0.723606797749979));
         Vertex.Add(81, new HVector(-0.276393202250021, -3.60341464929439, -1.17082039324994));
         Vertex.Add(82, new HVector(-0.276393202250021, -0.85065080835204, 3.06524758424985));
         Vertex.Add(83, new HVector(-0.276393202250021, 0.85065080835204, 3.06524758424985));
         Vertex.Add(84, new HVector(-0.276393202250021, 3.60341464929439, -1.17082039324994));
         Vertex.Add(85, new HVector(0, -4.45406545764643, 0));
         Vertex.Add(86, new HVector(0, -2.75276384094235, -2.61803398874989));
         Vertex.Add(87, new HVector(0, -2.75276384094235, -1.61803398874989));
         Vertex.Add(88, new HVector(0, -2.75276384094235, 1.61803398874989));
         Vertex.Add(89, new HVector(0, -2.75276384094235, 2.61803398874989));
         Vertex.Add(90, new HVector(0, 0, -4.23606797749979));
         Vertex.Add(91, new HVector(0, 0, 4.23606797749979));
         Vertex.Add(92, new HVector(0, 2.75276384094235, -2.61803398874989));
         Vertex.Add(93, new HVector(0, 2.75276384094235, -1.61803398874989));
         Vertex.Add(94, new HVector(0, 2.75276384094235, 1.61803398874989));
         Vertex.Add(95, new HVector(0, 2.75276384094235, 2.61803398874989));
         Vertex.Add(96, new HVector(0, 4.45406545764643, 0));
         Vertex.Add(97, new HVector(0.276393202250021, -3.60341464929439, 1.17082039324994));
         Vertex.Add(98, new HVector(0.276393202250021, -0.85065080835204, -3.06524758424985));
         Vertex.Add(99, new HVector(0.276393202250021, 0.85065080835204, -3.06524758424985));
         Vertex.Add(100, new HVector(0.276393202250021, 3.60341464929439, 1.17082039324994));
         Vertex.Add(101, new HVector(0.447213595499958, -3.07768353717525, -0.723606797749979));
         Vertex.Add(102, new HVector(0.447213595499958, -1.37638192047117, 3.51246117974981));
         Vertex.Add(103, new HVector(0.447213595499958, 1.37638192047117, 3.51246117974981));
         Vertex.Add(104, new HVector(0.447213595499958, 3.07768353717525, -0.723606797749979));
         Vertex.Add(105, new HVector(0.723606797749979, -2.22703272882321, -3.78885438199983));
         Vertex.Add(106, new HVector(0.723606797749979, -2.22703272882321, -2.17082039324994));
         Vertex.Add(107, new HVector(0.723606797749979, -0.525731112119134, 3.06524758424985));
         Vertex.Add(108, new HVector(0.723606797749979, 0.525731112119134, 3.06524758424985));
         Vertex.Add(109, new HVector(0.723606797749979, 2.22703272882321, -3.78885438199983));
         Vertex.Add(110, new HVector(0.723606797749979, 2.22703272882321, -2.17082039324994));
         Vertex.Add(111, new HVector(0.894427190999916, 0, -3.06524758424985));
         Vertex.Add(112, new HVector(1.17082039324994, -3.60341464929439, -1.89442719099992));
         Vertex.Add(113, new HVector(1.17082039324994, -3.60341464929439, -0.276393202250021));
         Vertex.Add(114, new HVector(1.17082039324994, -3.60341464929439, 2.34164078649987));
         Vertex.Add(115, new HVector(1.17082039324994, -3.60341464929439, 4.95967477524977));
         Vertex.Add(116, new HVector(1.17082039324994, -0.85065080835204, -3.51246117974981));
         Vertex.Add(117, new HVector(1.17082039324994, 0.85065080835204, -3.51246117974981));
         Vertex.Add(118, new HVector(1.17082039324994, 3.60341464929439, -1.89442719099992));
         Vertex.Add(119, new HVector(1.17082039324994, 3.60341464929439, -0.276393202250021));
         Vertex.Add(120, new HVector(1.17082039324994, 3.60341464929439, 2.34164078649987));
         Vertex.Add(121, new HVector(1.17082039324994, 3.60341464929439, 4.95967477524977));
         Vertex.Add(122, new HVector(1.44721359549996, -2.75276384094235, -0.723606797749979));
         Vertex.Add(123, new HVector(1.44721359549996, 0, 3.51246117974981));
         Vertex.Add(124, new HVector(1.44721359549996, 2.75276384094235, -0.723606797749979));
         Vertex.Add(125, new HVector(1.61803398874989, -2.22703272882321, -2.61803398874989));
         Vertex.Add(126, new HVector(1.61803398874989, -2.22703272882321, -1.61803398874989));
         Vertex.Add(127, new HVector(1.61803398874989, -2.22703272882321, 1.61803398874989));
         Vertex.Add(128, new HVector(1.61803398874989, -2.22703272882321, 2.61803398874989));
         Vertex.Add(129, new HVector(1.61803398874989, 2.22703272882321, -2.61803398874989));
         Vertex.Add(130, new HVector(1.61803398874989, 2.22703272882321, -1.61803398874989));
         Vertex.Add(131, new HVector(1.61803398874989, 2.22703272882321, 1.61803398874989));
         Vertex.Add(132, new HVector(1.61803398874989, 2.22703272882321, 2.61803398874989));
         Vertex.Add(133, new HVector(1.89442719099992, -5.8304473781176, 1.17082039324994));
         Vertex.Add(134, new HVector(1.89442719099992, -3.07768353717525, 1.17082039324994));
         Vertex.Add(135, new HVector(1.89442719099992, -1.37638192047117, 2.17082039324994));
         Vertex.Add(136, new HVector(1.89442719099992, -1.37638192047117, 3.78885438199983));
         Vertex.Add(137, new HVector(1.89442719099992, 1.37638192047117, 2.17082039324994));
         Vertex.Add(138, new HVector(1.89442719099992, 1.37638192047117, 3.78885438199983));
         Vertex.Add(139, new HVector(1.89442719099992, 3.07768353717525, 1.17082039324994));
         Vertex.Add(140, new HVector(1.89442719099992, 5.8304473781176, 1.17082039324994));
         Vertex.Add(141, new HVector(2.17082039324994, -2.22703272882321, 0.723606797749979));
         Vertex.Add(142, new HVector(2.17082039324994, 2.22703272882321, 0.723606797749979));
         Vertex.Add(143, new HVector(2.34164078649987, -2.75276384094235, -1.17082039324994));
         Vertex.Add(144, new HVector(2.34164078649987, 0, -3.78885438199983));
         Vertex.Add(145, new HVector(2.34164078649987, 0, -2.17082039324994));
         Vertex.Add(146, new HVector(2.34164078649987, 2.75276384094235, -1.17082039324994));
         Vertex.Add(147, new HVector(2.61803398874989, -3.60341464929439, 0));
         Vertex.Add(148, new HVector(2.61803398874989, -0.85065080835204, -2.61803398874989));
         Vertex.Add(149, new HVector(2.61803398874989, -0.85065080835204, -1.61803398874989));
         Vertex.Add(150, new HVector(2.61803398874989, -0.85065080835204, 1.61803398874989));
         Vertex.Add(151, new HVector(2.61803398874989, -0.85065080835204, 2.61803398874989));
         Vertex.Add(152, new HVector(2.61803398874989, 0.85065080835204, -2.61803398874989));
         Vertex.Add(153, new HVector(2.61803398874989, 0.85065080835204, -1.61803398874989));
         Vertex.Add(154, new HVector(2.61803398874989, 0.85065080835204, 1.61803398874989));
         Vertex.Add(155, new HVector(2.61803398874989, 0.85065080835204, 2.61803398874989));
         Vertex.Add(156, new HVector(2.61803398874989, 3.60341464929439, 0));
         Vertex.Add(157, new HVector(2.78885438199983, -1.37638192047117, 0.723606797749979));
         Vertex.Add(158, new HVector(2.78885438199983, 1.37638192047117, 0.723606797749979));
         Vertex.Add(159, new HVector(3.06524758424985, -2.22703272882321, -4.95967477524977));
         Vertex.Add(160, new HVector(3.06524758424985, -2.22703272882321, -2.34164078649987));
         Vertex.Add(161, new HVector(3.06524758424985, -2.22703272882321, 0.276393202250021));
         Vertex.Add(162, new HVector(3.06524758424985, -2.22703272882321, 1.89442719099992));
         Vertex.Add(163, new HVector(3.06524758424985, -0.525731112119134, -0.723606797749979));
         Vertex.Add(164, new HVector(3.06524758424985, 0.525731112119134, -0.723606797749979));
         Vertex.Add(165, new HVector(3.06524758424985, 2.22703272882321, -4.95967477524977));
         Vertex.Add(166, new HVector(3.06524758424985, 2.22703272882321, -2.34164078649987));
         Vertex.Add(167, new HVector(3.06524758424985, 2.22703272882321, 0.276393202250021));
         Vertex.Add(168, new HVector(3.06524758424985, 2.22703272882321, 1.89442719099992));
         Vertex.Add(169, new HVector(3.34164078649987, -1.37638192047117, -1.17082039324994));
         Vertex.Add(170, new HVector(3.34164078649987, 1.37638192047117, -1.17082039324994));
         Vertex.Add(171, new HVector(3.51246117974981, -0.85065080835204, 1.17082039324994));
         Vertex.Add(172, new HVector(3.51246117974981, 0.85065080835204, 1.17082039324994));
         Vertex.Add(173, new HVector(3.78885438199983, 0, -1.89442719099992));
         Vertex.Add(174, new HVector(3.78885438199983, 0, -0.276393202250021));
         Vertex.Add(175, new HVector(3.78885438199983, 0, 2.34164078649987));
         Vertex.Add(176, new HVector(3.78885438199983, 0, 4.95967477524977));
         Vertex.Add(177, new HVector(4.23606797749979, -1.37638192047117, 0));
         Vertex.Add(178, new HVector(4.23606797749979, 1.37638192047117, 0));
         Vertex.Add(179, new HVector(4.95967477524977, -3.60341464929439, -1.17082039324994));
         Vertex.Add(180, new HVector(4.95967477524977, 3.60341464929439, -1.17082039324994));
         Vertex.Add(181, new HVector(6.13049516849971, 0, 1.17082039324994));

          HPolygon hpoly;
          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(50);
         hpoly.AddIndex(51);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(40);
         hpoly.AddIndex(15);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(129);
         hpoly.AddIndex(128);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(142);
         hpoly.AddIndex(162);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(16);
         hpoly.AddIndex(52);
         hpoly.AddIndex(53);
         hpoly.AddIndex(72);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(160);
         hpoly.AddIndex(161);
         hpoly.AddIndex(127);
         hpoly.AddIndex(126);
         hpoly.AddIndex(107);
         hpoly.AddIndex(106);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(21);
         hpoly.AddIndex(41);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(55);
         hpoly.AddIndex(54);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(168);
         hpoly.AddIndex(143);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(132);
         hpoly.AddIndex(133);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(166);
         hpoly.AddIndex(110);
         hpoly.AddIndex(111);
         hpoly.AddIndex(130);
         hpoly.AddIndex(131);
         hpoly.AddIndex(167);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(77);
         hpoly.AddIndex(76);
         hpoly.AddIndex(57);
         hpoly.AddIndex(56);
         hpoly.AddIndex(22);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(79);
         hpoly.AddIndex(74);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(75);
         hpoly.AddIndex(80);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(13);
         hpoly.AddIndex(19);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(18);
         hpoly.AddIndex(12);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(49);
         hpoly.AddIndex(68);
         hpoly.AddIndex(55);
         hpoly.AddIndex(48);
         hpoly.AddIndex(41);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(42);
         hpoly.AddIndex(26);
         hpoly.AddIndex(40);
         hpoly.AddIndex(43);
         hpoly.AddIndex(51);
         hpoly.AddIndex(62);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(171);
         hpoly.AddIndex(165);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(164);
         hpoly.AddIndex(170);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(103);
         hpoly.AddIndex(108);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(109);
         hpoly.AddIndex(104);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(134);
         hpoly.AddIndex(148);
         hpoly.AddIndex(142);
         hpoly.AddIndex(135);
         hpoly.AddIndex(128);
         hpoly.AddIndex(115);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(141);
         hpoly.AddIndex(121);
         hpoly.AddIndex(132);
         hpoly.AddIndex(140);
         hpoly.AddIndex(143);
         hpoly.AddIndex(157);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(36);
         hpoly.AddIndex(58);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(78);
         hpoly.AddIndex(98);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(117);
         hpoly.AddIndex(99);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(74);
         hpoly.AddIndex(59);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(180);
         hpoly.AddIndex(148);
         hpoly.AddIndex(123);
         hpoly.AddIndex(144);
         hpoly.AddIndex(127);
         hpoly.AddIndex(161);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(7);
         hpoly.AddIndex(28);
         hpoly.AddIndex(10);
         hpoly.AddIndex(24);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(59);
         hpoly.AddIndex(75);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(100);
         hpoly.AddIndex(118);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(101);
         hpoly.AddIndex(81);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(60);
         hpoly.AddIndex(39);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(181);
         hpoly.AddIndex(167);
         hpoly.AddIndex(131);
         hpoly.AddIndex(147);
         hpoly.AddIndex(125);
         hpoly.AddIndex(157);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(5);
         hpoly.AddIndex(25);
         hpoly.AddIndex(11);
         hpoly.AddIndex(32);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(144);
         hpoly.AddIndex(123);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(102);
         hpoly.AddIndex(82);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(65);
         hpoly.AddIndex(83);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(108);
         hpoly.AddIndex(124);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(26);
         hpoly.AddIndex(58);
         hpoly.AddIndex(36);
         hpoly.AddIndex(52);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(182);
         hpoly.AddIndex(176);
         hpoly.AddIndex(151);
         hpoly.AddIndex(172);
         hpoly.AddIndex(158);
         hpoly.AddIndex(178);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(124);
         hpoly.AddIndex(109);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(84);
         hpoly.AddIndex(66);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(85);
         hpoly.AddIndex(105);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(125);
         hpoly.AddIndex(147);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(22);
         hpoly.AddIndex(56);
         hpoly.AddIndex(39);
         hpoly.AddIndex(60);
         hpoly.AddIndex(35);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(182);
         hpoly.AddIndex(179);
         hpoly.AddIndex(159);
         hpoly.AddIndex(173);
         hpoly.AddIndex(155);
         hpoly.AddIndex(176);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(43);
         hpoly.AddIndex(40);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(24);
         hpoly.AddIndex(10);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(66);
         hpoly.AddIndex(71);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(83);
         hpoly.AddIndex(103);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(5);
         hpoly.AddIndex(19);
         hpoly.AddIndex(13);
         hpoly.AddIndex(33);
         hpoly.AddIndex(22);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(134);
         hpoly.AddIndex(115);
         hpoly.AddIndex(89);
         hpoly.AddIndex(98);
         hpoly.AddIndex(78);
         hpoly.AddIndex(86);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(104);
         hpoly.AddIndex(84);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(92);
         hpoly.AddIndex(71);
         hpoly.AddIndex(65);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(11);
         hpoly.AddIndex(25);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(41);
         hpoly.AddIndex(48);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(16);
         hpoly.AddIndex(29);
         hpoly.AddIndex(12);
         hpoly.AddIndex(18);
         hpoly.AddIndex(4);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(141);
         hpoly.AddIndex(97);
         hpoly.AddIndex(81);
         hpoly.AddIndex(101);
         hpoly.AddIndex(95);
         hpoly.AddIndex(121);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(135);
         hpoly.AddIndex(142);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(158);
         hpoly.AddIndex(172);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(118);
         hpoly.AddIndex(112);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(99);
         hpoly.AddIndex(79);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(181);
         hpoly.AddIndex(179);
         hpoly.AddIndex(165);
         hpoly.AddIndex(171);
         hpoly.AddIndex(154);
         hpoly.AddIndex(167);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(42);
         hpoly.AddIndex(62);
         hpoly.AddIndex(88);
         hpoly.AddIndex(82);
         hpoly.AddIndex(102);
         hpoly.AddIndex(86);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(80);
         hpoly.AddIndex(100);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(91);
         hpoly.AddIndex(112);
         hpoly.AddIndex(117);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(173);
         hpoly.AddIndex(159);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(143);
         hpoly.AddIndex(140);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(180);
         hpoly.AddIndex(161);
         hpoly.AddIndex(150);
         hpoly.AddIndex(170);
         hpoly.AddIndex(164);
         hpoly.AddIndex(178);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(49);
         hpoly.AddIndex(97);
         hpoly.AddIndex(105);
         hpoly.AddIndex(85);
         hpoly.AddIndex(94);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(114);
         hpoly.AddIndex(102);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(88);
         hpoly.AddIndex(87);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(8);
         hpoly.AddIndex(18);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(29);
         hpoly.AddIndex(30);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(44);
         hpoly.AddIndex(45);
         hpoly.AddIndex(27);
         hpoly.AddIndex(28);
         hpoly.AddIndex(7);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(116);
         hpoly.AddIndex(73);
         hpoly.AddIndex(72);
         hpoly.AddIndex(90);
         hpoly.AddIndex(89);
         hpoly.AddIndex(115);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(93);
         hpoly.AddIndex(94);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(105);
         hpoly.AddIndex(120);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(34);
         hpoly.AddIndex(33);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(19);
         hpoly.AddIndex(8);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(122);
         hpoly.AddIndex(121);
         hpoly.AddIndex(95);
         hpoly.AddIndex(96);
         hpoly.AddIndex(76);
         hpoly.AddIndex(77);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(7);
         hpoly.AddIndex(32);
         hpoly.AddIndex(31);
         hpoly.AddIndex(47);
         hpoly.AddIndex(46);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(175);
         hpoly.AddIndex(164);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(150);
         hpoly.AddIndex(149);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(63);
         hpoly.AddIndex(78);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(89);
         hpoly.AddIndex(90);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(61);
         hpoly.AddIndex(106);
         hpoly.AddIndex(107);
         hpoly.AddIndex(87);
         hpoly.AddIndex(88);
         hpoly.AddIndex(62);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(177);
         hpoly.AddIndex(137);
         hpoly.AddIndex(136);
         hpoly.AddIndex(152);
         hpoly.AddIndex(151);
         hpoly.AddIndex(176);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(153);
         hpoly.AddIndex(154);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(165);
         hpoly.AddIndex(175);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(96);
         hpoly.AddIndex(95);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(81);
         hpoly.AddIndex(69);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(177);
         hpoly.AddIndex(176);
         hpoly.AddIndex(155);
         hpoly.AddIndex(156);
         hpoly.AddIndex(138);
         hpoly.AddIndex(139);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(67);
         hpoly.AddIndex(68);
         hpoly.AddIndex(94);
         hpoly.AddIndex(93);
         hpoly.AddIndex(111);
         hpoly.AddIndex(110);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(90);
         hpoly.AddIndex(72);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(52);
         hpoly.AddIndex(36);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(39);
         hpoly.AddIndex(56);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(76);
         hpoly.AddIndex(96);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(1);
         hpoly.AddIndex(4);
         hpoly.AddIndex(18);
         hpoly.AddIndex(8);
         hpoly.AddIndex(19);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(177);
         hpoly.AddIndex(139);
         hpoly.AddIndex(109);
         hpoly.AddIndex(124);
         hpoly.AddIndex(108);
         hpoly.AddIndex(137);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(87);
         hpoly.AddIndex(107);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(127);
         hpoly.AddIndex(144);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(147);
         hpoly.AddIndex(131);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(111);
         hpoly.AddIndex(93);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(182);
         hpoly.AddIndex(178);
         hpoly.AddIndex(164);
         hpoly.AddIndex(175);
         hpoly.AddIndex(165);
         hpoly.AddIndex(179);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(6);
         hpoly.AddIndex(46);
         hpoly.AddIndex(75);
         hpoly.AddIndex(59);
         hpoly.AddIndex(74);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(152);
         hpoly.AddIndex(136);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(128);
         hpoly.AddIndex(135);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(12);
         hpoly.AddIndex(29);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(37);
         hpoly.AddIndex(34);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(42);
         hpoly.AddIndex(86);
         hpoly.AddIndex(78);
         hpoly.AddIndex(63);
         hpoly.AddIndex(58);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(122);
         hpoly.AddIndex(77);
         hpoly.AddIndex(84);
         hpoly.AddIndex(104);
         hpoly.AddIndex(109);
         hpoly.AddIndex(139);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(140);
         hpoly.AddIndex(132);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(138);
         hpoly.AddIndex(156);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(30);
         hpoly.AddIndex(37);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(9);
         hpoly.AddIndex(33);
         hpoly.AddIndex(13);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(116);
         hpoly.AddIndex(137);
         hpoly.AddIndex(108);
         hpoly.AddIndex(103);
         hpoly.AddIndex(83);
         hpoly.AddIndex(73);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(49);
         hpoly.AddIndex(35);
         hpoly.AddIndex(60);
         hpoly.AddIndex(69);
         hpoly.AddIndex(81);
         hpoly.AddIndex(97);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(170);
         hpoly.AddIndex(150);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(146);
         hpoly.AddIndex(153);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(27);
         hpoly.AddIndex(45);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(51);
         hpoly.AddIndex(43);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(67);
         hpoly.AddIndex(110);
         hpoly.AddIndex(100);
         hpoly.AddIndex(80);
         hpoly.AddIndex(75);
         hpoly.AddIndex(46);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(134);
         hpoly.AddIndex(86);
         hpoly.AddIndex(102);
         hpoly.AddIndex(114);
         hpoly.AddIndex(123);
         hpoly.AddIndex(148);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(149);
         hpoly.AddIndex(146);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(174);
         hpoly.AddIndex(154);
         hpoly.AddIndex(171);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(48);
         hpoly.AddIndex(55);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(47);
         hpoly.AddIndex(31);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(141);
         hpoly.AddIndex(157);
         hpoly.AddIndex(125);
         hpoly.AddIndex(120);
         hpoly.AddIndex(105);
         hpoly.AddIndex(97);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(61);
         hpoly.AddIndex(44);
         hpoly.AddIndex(74);
         hpoly.AddIndex(79);
         hpoly.AddIndex(99);
         hpoly.AddIndex(106);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(82);
         hpoly.AddIndex(88);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(107);
         hpoly.AddIndex(126);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(54);
         hpoly.AddIndex(47);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(32);
         hpoly.AddIndex(11);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(166);
         hpoly.AddIndex(145);
         hpoly.AddIndex(112);
         hpoly.AddIndex(118);
         hpoly.AddIndex(100);
         hpoly.AddIndex(110);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(2);
         hpoly.AddIndex(4);
         hpoly.AddIndex(24);
         hpoly.AddIndex(15);
         hpoly.AddIndex(40);
         hpoly.AddIndex(26);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(10);
         hpoly.AddIndex(28);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(45);
         hpoly.AddIndex(50);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(130);
         hpoly.AddIndex(111);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(94);
         hpoly.AddIndex(85);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(160);
         hpoly.AddIndex(106);
         hpoly.AddIndex(99);
         hpoly.AddIndex(117);
         hpoly.AddIndex(112);
         hpoly.AddIndex(145);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(3);
         hpoly.AddIndex(35);
         hpoly.AddIndex(41);
         hpoly.AddIndex(21);
         hpoly.AddIndex(25);
         hpoly.AddIndex(5);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(98);
         hpoly.AddIndex(89);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(72);
         hpoly.AddIndex(53);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(133);
         hpoly.AddIndex(138);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(155);
         hpoly.AddIndex(173);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(38);
         hpoly.AddIndex(71);
         hpoly.AddIndex(66);
         hpoly.AddIndex(84);
         hpoly.AddIndex(77);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(180);
         hpoly.AddIndex(178);
         hpoly.AddIndex(158);
         hpoly.AddIndex(162);
         hpoly.AddIndex(142);
         hpoly.AddIndex(148);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(172);
         hpoly.AddIndex(151);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(136);
         hpoly.AddIndex(129);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(57);
         hpoly.AddIndex(76);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(95);
         hpoly.AddIndex(101);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(73);
         hpoly.AddIndex(83);
         hpoly.AddIndex(65);
         hpoly.AddIndex(71);
         hpoly.AddIndex(38);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(181);
         hpoly.AddIndex(157);
         hpoly.AddIndex(143);
         hpoly.AddIndex(168);
         hpoly.AddIndex(159);
         hpoly.AddIndex(179);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(31);
         hpoly.AddIndex(32);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(20);
         hpoly.AddIndex(25);
         hpoly.AddIndex(21);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(53);
         hpoly.AddIndex(52);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(64);
         hpoly.AddIndex(58);
         hpoly.AddIndex(63);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(23);
         hpoly.AddIndex(22);
         hpoly.AddIndex(33);
         hpoly.AddIndex(34);
         hpoly.AddIndex(37);
         hpoly.AddIndex(38);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(61);
         hpoly.AddIndex(62);
         hpoly.AddIndex(51);
         hpoly.AddIndex(50);
         hpoly.AddIndex(45);
         hpoly.AddIndex(44);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(15);
         hpoly.AddIndex(24);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(14);
         hpoly.AddIndex(28);
         hpoly.AddIndex(27);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(69);
         hpoly.AddIndex(60);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(70);
         hpoly.AddIndex(56);
         hpoly.AddIndex(57);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(67);
         hpoly.AddIndex(46);
         hpoly.AddIndex(47);
         hpoly.AddIndex(54);
         hpoly.AddIndex(55);
         hpoly.AddIndex(68);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(17);
         hpoly.AddIndex(38);
         hpoly.AddIndex(37);
         hpoly.AddIndex(30);
         hpoly.AddIndex(29);
         hpoly.AddIndex(16);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(126);
         hpoly.AddIndex(127);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(113);
         hpoly.AddIndex(123);
         hpoly.AddIndex(114);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(156);
         hpoly.AddIndex(155);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(169);
         hpoly.AddIndex(159);
         hpoly.AddIndex(168);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(116);
         hpoly.AddIndex(115);
         hpoly.AddIndex(128);
         hpoly.AddIndex(129);
         hpoly.AddIndex(136);
         hpoly.AddIndex(137);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(166);
         hpoly.AddIndex(167);
         hpoly.AddIndex(154);
         hpoly.AddIndex(153);
         hpoly.AddIndex(146);
         hpoly.AddIndex(145);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(120);
         hpoly.AddIndex(125);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(119);
         hpoly.AddIndex(131);
         hpoly.AddIndex(130);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(162);
         hpoly.AddIndex(158);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(163);
         hpoly.AddIndex(151);
         hpoly.AddIndex(152);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(160);
         hpoly.AddIndex(145);
         hpoly.AddIndex(146);
         hpoly.AddIndex(149);
         hpoly.AddIndex(150);
         hpoly.AddIndex(161);
         Polygons.Add(hpoly);

          hpoly = new HPolygon();
         hpoly.AddIndex(122);
         hpoly.AddIndex(139);
         hpoly.AddIndex(138);
         hpoly.AddIndex(133);
         hpoly.AddIndex(132);
         hpoly.AddIndex(121);
         Polygons.Add(hpoly);


       }

       

    }
}
