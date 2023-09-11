using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parkview.Models;
using Parkview.ViewModels;
using Stripe.Tax;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System;

namespace Parkview.Models
{
    public class ParkviewDbContext : IdentityDbContext
    {
        public ParkviewDbContext(DbContextOptions<ParkviewDbContext> options): base(options)
        { }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelChain> HotelChains { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Booking> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this is where we will configure our relationships
            //---------------------------------------------------hotel---------------------------------------------------
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hotel>().HasData
                (new Hotel
                {
                    HotelId = 1,
                    Name = "Parkview Solstice Resorts",
                    Description = "Discover the solstice of your dreams at Parkview Solstice Resorts, where nature's beauty and opulent hospitality harmoniously coexist.",
                    ImageUrl = "/images/pk_bang.jpg",
                    HotelChainId = 1
                });

            modelBuilder.Entity<Hotel>().
                HasData(new Hotel
                {
                    HotelId = 2,
                    Name = "Parkview Paradise Retreat",
                    Description = "Indulge in the ultimate retreat at Parkview Paradise, where every moment is an opportunity for relaxation and rejuvenation.",
                    ImageUrl = "/images/hotelview.jpg",
                    HotelChainId = 1
                });

            modelBuilder.Entity<Hotel>().HasData
                (new Hotel
                {
                    HotelId = 3,
                    Name = "Crystal Lake Parkview Inn",
                    Description = "Escape to a world of tranquility at Crystal Lake Parkview Inn, where the harmonious blend of modern luxury and natural beauty awaits.",
                    ImageUrl = "/images/pktaj.jpg",
                    HotelChainId = 2
                });

            modelBuilder.Entity<Hotel>().HasData
                (new Hotel
                {
                    HotelId = 4,
                    Name = "Parkview Serendipity Manor",
                    Description = "Discover the magic of Parkview Serendipity Manor, where sophistication meets comfort in a splendid setting, creating unforgettable memories.",
                    ImageUrl = "/images/pk_del.jpg",
                    HotelChainId = 3
                });

            modelBuilder.Entity<Hotel>().HasData
                (new Hotel
                {
                    HotelId = 5,
                    Name = "Whispering Pines Parkview",
                    Description = "Whispering Pines Parkview beckons you to a world of peaceful seclusion, where the song of the pines and the elegance of hospitality create an unforgettable experience.",
                    ImageUrl = "/images/itc_chen.jpg",
                    HotelChainId = 4
                });

            modelBuilder.Entity<Hotel>().HasData
                (new Hotel
                {
                    HotelId = 6,
                    Name = "Majestic Parkview Residences",
                    Description = "Experience the grandeur of city living at Majestic Parkview Residences, where opulence meets urban convenience in every corner.",
                    ImageUrl = "/images/hotelviewkol.jpg",
                    HotelChainId = 5
                });

            modelBuilder.Entity<Hotel>().HasData
                (new Hotel
                {
                    HotelId = 7,
                    Name = "Parkview Vista Villas",
                    Description = "Experience elevated living at Parkview Vista Villas, where panoramic vistas meet modern elegance.",
                    ImageUrl = "/images/hotel.jpg",
                    HotelChainId = 6
                });

            modelBuilder.Entity<Hotel>().HasData
                (new Hotel
                {
                    HotelId = 8,
                    Name = "Parkview Palms Oasis",
                    Description = "Escape to Parkview Palms Oasis, where lush greenery meets ultimate relaxation, your oasis of tranquility.",
                    ImageUrl = "/images/hotelarielview.jpg",
                    HotelChainId = 7
                });


            //---------------------------------------------hotel chain--------------------------------------------
            modelBuilder.Entity<HotelChain>().HasData
                (new HotelChain
                {
                    HotelChainId = 1,
                    Name = "Parkview Karnataka Chain",
                    Description = "Parkview Bangalore is a 5-star hotel located in the heart of Bangalore.",
                    ImageUrl = "images/chain_bangalore.png",
                    LocationId = 1,
                    DestinationId = 1
                });

            modelBuilder.Entity<HotelChain>().HasData
                (new HotelChain
                {
                    HotelChainId = 2,
                    Name = "Parkview Maharashtra Chain",
                    Description = "Parkview Mumbai is a 5-star hotel located in the heart of Mumbai.",
                    ImageUrl = "images/chain_mumbai.png",
                    LocationId = 2,
                    DestinationId = 2
                });

            modelBuilder.Entity<HotelChain>().HasData
                (new HotelChain
                {
                    HotelChainId = 3,
                    Name = "Parkview Delhi Chain",
                    Description = "Parkview Delhi is a 5-star hotel located in the heart of Delhi.",
                    ImageUrl = "images/chain_delhi.png",
                    LocationId = 3,
                    DestinationId = 3
                });

            modelBuilder.Entity<HotelChain>().HasData
                (new HotelChain
                {
                    HotelChainId = 4,
                    Name = "Parkview Tamil Nadu Chain",
                    Description = "Parkview Chennai is a 5-star hotel located in the heart of Chennai.",
                    ImageUrl = "images/chain_chennai.png",
                    LocationId = 4,
                    DestinationId = 4
                });

            modelBuilder.Entity<HotelChain>().HasData
                (new HotelChain
                {
                    HotelChainId = 5,
                    Name = "Parkview West Bengal Chain",
                    Description = "Parkview Kolkata is a 5-star hotel located in the heart of Kolkata.",
                    ImageUrl = "images/chain_kolkata.png",
                    LocationId = 5,
                    DestinationId = 5
                });

            modelBuilder.Entity<HotelChain>().HasData
                (new HotelChain
                {
                    HotelChainId = 6,
                    Name = "Parkview Jammu & Kashmir Chain",
                    Description = "Parkview Ladakh is a 5-star hotel located in the heart of Hyderabad.",
                    ImageUrl = "images/chain_ladakh.png",
                    LocationId = 6,
                    DestinationId = 6
                });

            modelBuilder.Entity<HotelChain>().HasData
                (new HotelChain
                {
                    HotelChainId = 7,
                    Name = "Parkview Maldives Chain",
                    Description = "Parkview Maldives is a 5-star hotel located in the heart of Pune.",
                    ImageUrl = "images/chain_maldives.png",
                    LocationId = 7,
                    DestinationId = 7
                });


            //------------------------------------------------location-----------------------------------------------
            modelBuilder.Entity<Location>().HasData
                (new Location
                {
                    LocationId = 1,
                    Name = "Bangalore",
                    Description = "Bangalore is the capital of the Indian state of Karnataka. It has a population of over ten million, making it a megacity and the third-most populous city and fifth-most populous urban agglomeration in India.",
                    ImageUrl = "images/loc_bangalore.jpg",
                });

            modelBuilder.Entity<Location>().HasData
                (new Location
                {
                    LocationId = 2,
                    Name = "Mumbai",
                    Description = "Mumbai is the capital city of the Indian state of Maharashtra. According to the United Nations, as of 2018, Mumbai is the second-most populous city in the country after Delhi and the seventh-most populous city in the world with a population of roughly 20 million.",
                    ImageUrl = "images/loc_mumbai.jpg",
                });

            modelBuilder.Entity<Location>().HasData
                (new Location
                {
                    LocationId = 3,
                    Name = "Delhi",
                    Description = "Delhi, officially the National Capital Territory of Delhi, is a city and a union territory of India containing New Delhi, the capital of India. It is bordered by the state of Haryana on three sides and by Uttar Pradesh to the east.",
                    ImageUrl = "images/loc_delhi.jpg",
                });

            modelBuilder.Entity<Location>().HasData
                (new Location
                {
                    LocationId = 4,
                    Name = "Chennai",
                    Description = "Chennai is the capital of the Indian state of Tamil Nadu. Located on the Coromandel Coast off the Bay of Bengal, it is one of the largest cultural, economic and educational centres of south India.",
                    ImageUrl = "images/loc_chennai.jpg",
                });

            modelBuilder.Entity<Location>().HasData
                (new Location
                {
                    LocationId = 5,
                    Name = "Kolkata",
                    Description = "Kolkata is the capital of the Indian state of West Bengal. Located on the eastern bank of the Hooghly River, the city is approximately 80 kilometres west of the border with Bangladesh.",
                    ImageUrl = "images/loc_kolkata.jpg",
                });


            //-----------------------------------------------------room-----------------------------------------------------
           

               modelBuilder.Entity<Room>().HasData
                (new Room
                {
                    RoomId = 1,
                    Name = "Queen's Hub",
                    Description = "Standard room with a queen-sized bed",
                    ImageUrl = "/images/pk_chenroom.jpg",
                    HotelId = 1,
                    NoOfRooms = 50,
                    RoomType = "Deluxe",
                    RoomPrice = 8000m,
                });

                modelBuilder.Entity<Room>().HasData
                  (new Room
                  { 
                     RoomId = 2,
                     Name = "Queen's Hub",
                     Description = "Luxury room",
                     ImageUrl = "/images/lux_accom.jpeg",
                     HotelId = 1,
                     NoOfRooms = 35,
                     RoomType = "Super Deluxe",
                     RoomPrice = 14000m,
                  });


                modelBuilder.Entity<Room>().HasData 
                  (new Room
                  {
                       RoomId = 3,
                       Name = "king's Palace",
                       Description = "Standard room with a queen-sized bed",
                       ImageUrl = "/images/room1mal.jpg",
                       HotelId = 2,
                       NoOfRooms = 65,
                       RoomType = "Executive",
                       RoomPrice = 20000m,
                   });



                modelBuilder.Entity<Room>().HasData
                    (new Room
                    {
                        RoomId = 4,
                        Name = "king's Palace",
                        Description = "Luxury room",
                        ImageUrl = "/images/room2maljpg",
                        HotelId = 2,
                        NoOfRooms = 55,
                        RoomType = "Presidential Suite",
                        RoomPrice = 28000m,
                    });


                modelBuilder.Entity<Room>().HasData
                   (new Room
                   {
                       RoomId = 5,
                       Name = "Prince's clan",
                       Description = "Standard room with a queen-sized bed",
                       ImageUrl = "/images/luxury_accom.jpeg",
                       HotelId = 3,
                       NoOfRooms = 20,
                       RoomType = "Presidential Suite",
                       RoomPrice = 28000m,
                   });



                modelBuilder.Entity<Room>().HasData
                    (new Room
                    {
                        RoomId = 6,
                        Name = "Lion's Den",
                        Description = "Standard room with a queen-sized bed",
                        ImageUrl = "/images/luxury_accom.jpeg",
                        HotelId = 4,
                        NoOfRooms = 30,
                        RoomType = "Executive",
                        RoomPrice = 20000m,
                    });



                modelBuilder.Entity<Room>().HasData
                     (new Room
                     {
                         RoomId = 7,
                         Name = "Tiger's Den",
                         Description = "Standard room with a queen-sized bed",
                         ImageUrl = "/images/luxury_accom.jpeg",
                         HotelId = 5,
                         NoOfRooms = 45,
                         RoomType = "Deluxe",
                         RoomPrice = 8000m,
                     });

//----------------------------------------------------Destination------------------------------------------------------


modelBuilder.Entity<Destination>().HasData
                (new Destination
                {
                    DestinationId = 1,
                    DestinationName = "Mysore",
                    DestinationState = "Karnataka",
                    DestinationDescription = "Mysore Palace, a masterpiece of Indo-Saracenic architecture, stands as a testament to the grandeur of India's royal heritage.",
                    DestinationDetailedDescription = "Mysore Palace: Located in the city of Mysore, the Mysore Palace is a magnificent example of Indo-Saracenic architecture. It's one of the most visited tourist spots in Karnataka, attracting millions of visitors every year. The palace is known for its opulent interiors, intricate artwork, and beautifully landscaped gardens. The grandeur of the palace is best witnessed during the annual Dasara festival when it is illuminated with thousands of lights.\r\n\r\nHampi: Hampi is a UNESCO World Heritage Site known for its surreal landscape filled with ancient temples, ruins, and boulders. It was once the capital of the Vijayanagara Empire and is now a popular destination for history enthusiasts and backpackers. The Virupaksha Temple, Hampi Bazaar, and the stunning Vittala Temple with its iconic stone chariot are among the must-visit attractions.\r\n\r\nCoorg: Nestled in the Western Ghats, Coorg is a picturesque hill station known for its lush coffee plantations, misty landscapes, and serene homestays. Visitors can explore the coffee estates, go trekking in the dense forests, or simply unwind amidst the natural beauty. Abbey Falls, Raja's Seat, and the Tibetan Golden Temple are some of the top attractions in Coorg.\r\n\r\nGokarna: Gokarna, a tranquil coastal town, has gained popularity for its pristine beaches and laid-back atmosphere. Om Beach, Kudle Beach, and Half Moon Beach are perfect for sunbathing and water sports. Gokarna is also a significant pilgrimage site with the revered Mahabaleshwar Temple, making it a unique blend of spirituality and leisure.\r\n\r\nBadami: Badami is renowned for its rock-cut cave temples and ancient architecture. These stunning sandstone cave temples date back to the 6th century and feature intricate carvings depicting various mythological stories. Badami also offers the opportunity for outdoor enthusiasts to explore the nearby Agastya Lake and Badami Fort.\r\n\r\nHassan: Hassan is a city with a rich historical and architectural heritage. The star attraction is the Chennakesava Temple at Belur, a masterpiece of Hoysala architecture known for its intricate sculptures. Halebidu, another nearby town, boasts the Hoysaleswara Temple, adorned with exceptional stone carvings. Shravanabelagola, with its colossal Gommateshwara statue, is another significant site nearby.\r\n\r\nJog Falls: Located in the Shimoga district, Jog Falls is one of India's tallest waterfalls. It's a sight to behold during the monsoon season when the Sharavathi River plummets down the rocky cliffs in four distinct cascades. The lush green surroundings and the roar of the falls make it a popular destination for nature lovers and photographers.\r\n\r\nAihole and Pattadakal: These two historic towns are often referred to as the \"Cradle of Indian Temple Architecture.\" Aihole is known for its early Chalukyan temples, while Pattadakal features a remarkable blend of North and South Indian architectural styles. Both sites are UNESCO World Heritage Sites and offer a glimpse into the evolution of temple architecture in India.\r\n\r\nKarnataka's diverse attractions, spanning from historical sites to natural wonders, offer a rich and immersive experience for travelers from around the world.",
                    DestinationPrice = 60000.00m,
                    DestinationImageUrl = "/images/Mysore.jpg",
                    DestinationVideoUrl = "/videos/karnataka_dest.mp4",
                    DestLocationId = 1,
                    HotelChainId = 1
                });

            modelBuilder.Entity<Destination>().HasData
                (new Destination
                {
                    DestinationId = 6,
                    DestinationName = "Ladakh",
                    DestinationState = "Jammu and Kashmir",
                    DestinationDescription = "Ladakh is a paradise for adventure enthusiasts, with opportunities for trekking, river rafting, and motorbike journeys through challenging terrains.",
                    DestinationDetailedDescription = "Leh: The capital city of Ladakh, Leh, is a gateway to the region's breathtaking landscapes and cultural heritage. The Leh Palace, a historic royal residence, offers panoramic views of the town. Visitors can explore the bustling Leh Market, the ancient Shey Monastery, and the serene Shanti Stupa, which provides a sense of tranquility amidst the stunning Himalayan backdrop.\r\n\r\nPangong Lake: This mesmerizing high-altitude lake, featured in the movie \"3 Idiots,\" is known for its ever-changing shades of blue. Situated at an altitude of about 14,270 feet, Pangong Tso is a popular destination for camping, stargazing, and enjoying the serene beauty of the Ladakhi landscape.\r\n\r\nNubra Valley: Located in the northern part of Ladakh, Nubra Valley is a hidden gem with stark desert landscapes and lush green valleys. The valley is accessible via the famous Khardung La pass, one of the world's highest motorable roads. Visitors can ride Bactrian camels in the sand dunes of Hunder and explore the ancient Diskit Monastery.\r\n\r\nTso Moriri Lake: Situated in the remote Changthang region, Tso Moriri is a serene high-altitude lake surrounded by snow-capped peaks. It is a paradise for birdwatchers, as migratory birds flock to the lake during the summer. The region is also known for its traditional Tibetan culture and monasteries like Karzok Gompa.\r\n\r\nZanskar Valley: Often referred to as the \"Land of Lamas,\" Zanskar Valley is known for its stunning landscapes, including deep gorges and pristine rivers. The frozen Zanskar River offers a unique adventure – the Chadar Trek, where trekkers walk on the frozen river during the winter months.\r\n\r\nHemis Monastery: This 17th-century Buddhist monastery is not only a religious center but also famous for hosting the colorful Hemis Festival, celebrating the birth of Guru Padmasambhava. The monastery houses a museum with a remarkable collection of ancient artifacts and thangkas (Buddhist paintings).\r\n\r\nAlchi Monastery: Known for its ancient murals and frescoes, Alchi Monastery is a hidden treasure tucked away in a quiet village. It is renowned for its unique Kashmiri-style architecture and serene surroundings.\r\n\r\nKargil: Famous for its historical significance in the 1999 Kargil War, Kargil is a town that offers a glimpse into the region's wartime history. The Kargil War Memorial in Dras is a tribute to the soldiers who sacrificed their lives during the conflict.\r\n\r\nLadakh, often referred to as the \"Land of High Passes,\" is a destination that captivates travelers with its rugged beauty, cultural richness, and opportunities for adventure in the midst of the Himalayas. Each of these tourist spots in Ladakh showcases a different facet of this stunning region.",
                    DestinationPrice = 35000.00m,
                    DestinationImageUrl = "/images/ladakh.jpg",
                    DestinationVideoUrl = "/videos/ladakh_dest.mp4",
                    DestLocationId = 1,
                    HotelChainId = 6
                });

            modelBuilder.Entity<Destination>().HasData
                (new Destination
                {
                    DestinationId = 3,
                    DestinationName = "Delhi",
                    DestinationState = "Delhi",
                    DestinationDescription = "As the sun sets, the Taj Mahal transforms into a mesmerizing spectacle, casting its reflection in the tranquil waters of its surrounding gardens.",
                    DestinationDetailedDescription = "The Red Fort: One of Delhi's most iconic landmarks, the Red Fort, also known as Lal Qila, is a UNESCO World Heritage Site and a symbol of India's rich history. This majestic red sandstone fort was built by Emperor Shah Jahan in the 17th century and served as the main residence of the Mughal emperors. Its impressive architecture, including intricate marble inlays and sprawling courtyards, makes it a must-visit attraction.\r\n\r\nIndia Gate: A prominent war memorial located at the heart of New Delhi, India Gate stands as a tribute to the soldiers who sacrificed their lives during World War I. Surrounded by beautifully landscaped lawns, this grand archway is a popular spot for picnics and evening strolls, and it is particularly stunning when illuminated at night.\r\n\r\nQutub Minar: Another UNESCO World Heritage Site, the Qutub Minar is a towering minaret that dates back to the 12th century. It is a fine example of Indo-Islamic architecture and is surrounded by a complex of ancient ruins and monuments, including the Iron Pillar of Delhi, known for its rust-free, centuries-old iron structure.\r\n\r\nHumayun's Tomb: This magnificent garden tomb is often regarded as the precursor to the Taj Mahal due to its elegant Mughal architecture. Humayun's Tomb is a UNESCO World Heritage Site and a serene oasis in the bustling city. Its pristine gardens, symmetrical design, and red sandstone architecture make it a photographer's delight.\r\n\r\nLotus Temple: Known for its unique lotus flower-shaped architecture, the Lotus Temple is a Bahá'í House of Worship and a symbol of religious unity. It welcomes people of all faiths to meditate and pray in its serene ambiance. The temple's white marble structure is particularly striking against the blue sky.\r\n\r\nAkshardham Temple: This sprawling complex in Delhi showcases a blend of art, spirituality, and traditional Indian craftsmanship. The Akshardham Temple, dedicated to Bhagwan Swaminarayan, features intricately carved sandstone and marble, a mesmerizing musical fountain, and exhibitions on India's cultural and spiritual heritage.\r\n\r\nJama Masjid: India's largest mosque, the Jama Masjid, is an architectural marvel constructed by Emperor Shah Jahan in the 17th century. Its vast courtyard can accommodate thousands of worshipers. Visitors can climb the minaret for panoramic views of Old Delhi.\r\n\r\nChandni Chowk: Located in the heart of Old Delhi, Chandni Chowk is a bustling market area renowned for its vibrant bazaars, street food, and historical significance. Exploring the narrow lanes, one can find everything from spices and textiles to jewelry and electronics, making it a shopper's paradise.\r\n\r\nDelhi, the capital of India, is a treasure trove of historical and cultural landmarks that offer a fascinating glimpse into the country's rich past and vibrant present. Each of these tourist spots has its unique charm and significance, making Delhi a captivating destination for travelers.",
                    DestinationPrice = 32000.00m,
                    DestinationImageUrl = "/images/taj_mahal.jpg",
                    DestinationVideoUrl = "/videos/delhi_dest.mp4",
                    DestLocationId = 3,
                    HotelChainId = 3
                });

            modelBuilder.Entity<Destination>().HasData
                (new Destination
                {
                    DestinationId = 2,
                    DestinationName = "Mumbai",
                    DestinationState = "Maharashtra",
                    DestinationDescription = "Tourists flock to the Gateway of India to admire its Indo-Saracenic architecture and relive the city's colonial past with ParkView Maharashtra chains of hotels,Parkview",
                    DestinationDetailedDescription = "Mumbai: The bustling capital city of Maharashtra, Mumbai, is a vibrant metropolis known for its eclectic mix of culture, history, and modernity. Iconic attractions include the Gateway of India, Marine Drive, and the historic Chhatrapati Shivaji Terminus. The city is also home to Bollywood, offering tours of film studios and a chance to explore the world of Indian cinema.\r\n\r\nAjanta and Ellora Caves: Located in the Aurangabad district, these UNESCO World Heritage Sites are a testament to India's ancient art and architecture. The Ajanta Caves feature intricate Buddhist rock-cut caves adorned with stunning paintings, while the Ellora Caves showcase a blend of Buddhist, Hindu, and Jain temples carved into the rocky landscape.\r\n\r\nPune: Known as the \"Oxford of the East,\" Pune is a city of learning and culture. It boasts numerous historical sites like the Aga Khan Palace, Shaniwar Wada, and the Raja Dinkar Kelkar Museum. The city is also surrounded by scenic hill stations such as Lonavala and Khandala.\r\n\r\nAurangabad: This city is the gateway to the Ajanta and Ellora Caves and offers a rich historical experience. The Bibi Ka Maqbara, often called the \"Mini Taj Mahal,\" is a noteworthy attraction. The city's vibrant bazaars and culinary delights make it a must-visit destination for history buffs and foodies alike.\r\n\r\nMahabaleshwar: Nestled in the Western Ghats, Mahabaleshwar is a charming hill station famous for its lush greenery and panoramic viewpoints. The town is renowned for its strawberries and offers activities like trekking, boating in Venna Lake, and visits to the Pratapgad Fort.\r\n\r\nAurangabad Caves: These lesser-known caves near Aurangabad are a hidden gem of ancient Buddhist architecture. Carved out of rock, they contain intricate sculptures and inscriptions that date back to the 6th and 7th centuries. The caves offer a peaceful and off-the-beaten-path experience for history enthusiasts.\r\n\r\nElephanta Island: A short ferry ride from Mumbai, Elephanta Island is famous for its ancient cave temples, particularly the main Shiva temple. The intricate rock-cut sculptures and caves, dating back to the 5th to 8th centuries, provide a glimpse into India's rich artistic heritage.\r\n\r\nKhandala and Lonavala: These twin hill stations in the Western Ghats are known for their stunning landscapes, waterfalls, and cool climate. Bhushi Dam, Karla Caves, and Tiger's Leap are some of the popular attractions. The scenic train journey on the Mumbai-Pune route adds to the charm of visiting these hill stations.\r\n\r\nMaharashtra's diverse attractions, ranging from vibrant cities to ancient caves and serene hill stations, offer a wide range of experiences for travelers seeking culture, history, and natural beauty.",
                    DestinationPrice = 50000.00m,
                    DestinationImageUrl = "/images/gateway.jpg",
                    DestinationVideoUrl = "/videos/mum_dest.mp4",
                    DestLocationId = 2,
                    HotelChainId = 2
                });


            modelBuilder.Entity<Destination>().HasData
                (new Destination
                {
                    DestinationId = 4,
                    DestinationName = "Chennai",
                    DestinationState = "Tamil Nadu",
                    DestinationDescription = "Marina Beach, stretching along the Bay of Bengal, is an iconic coastal paradise that entices with its golden sands and serene waters.",
                    DestinationDetailedDescription = "Mahabalipuram: Located along the scenic Coromandel Coast, Mahabalipuram, also known as Mamallapuram, is a UNESCO World Heritage Site famous for its ancient rock-cut temples and stunning Shore Temple, which stands as a testament to Pallava architecture. The town is also renowned for its intricately carved monolithic structures, including the famous \"Arjuna's Penance\" relief, making it a paradise for history and art enthusiasts.\r\n\r\nChennai: The capital city of Tamil Nadu, Chennai, is a bustling metropolis with a unique blend of tradition and modernity. Marina Beach, one of the longest urban beaches in the world, is a popular spot for leisurely walks and enjoying the sea breeze. The city is also home to cultural landmarks like Kapaleeshwarar Temple and the historic Fort St. George.\r\n\r\nMadurai: Known as the \"City of Temples,\" Madurai boasts the magnificent Meenakshi Amman Temple, an architectural masterpiece dedicated to the goddess Meenakshi. The temple complex is adorned with intricate carvings, towering gopurams (temple towers), and a sacred tank. Madurai's vibrant bazaars and bustling streets add to its charm.\r\n\r\nRameswaram: Situated on Pamban Island, Rameswaram is a pilgrimage destination for Hindus and is famous for the Ramanathaswamy Temple, which is one of the twelve Jyotirlinga shrines. The town is also known for its pristine beaches and the iconic Pamban Bridge, offering breathtaking views of the Indian Ocean.\r\n\r\nOoty: Nestled in the Nilgiri Hills, Ooty is a popular hill station known for its cool climate and scenic beauty. The Nilgiri Mountain Railway, a UNESCO World Heritage Site, takes visitors on a picturesque journey through lush tea gardens, dense forests, and picturesque valleys. Ooty Botanical Gardens and Ooty Lake are other major attractions.\r\n\r\nKodaikanal: Another serene hill station in Tamil Nadu, Kodaikanal is often referred to as the \"Princess of Hill Stations.\" Its lush green landscapes, serene lakes, and misty hills make it a perfect retreat for nature lovers. The Kodaikanal Lake, Coaker's Walk, and the Pillar Rocks are some of the enchanting spots to visit.\r\n\r\nThanjavur: Also known as Tanjore, Thanjavur is a cultural hub renowned for its classical music, dance, and traditional art forms. The Brihadeeswarar Temple, a UNESCO World Heritage Site, is a masterpiece of Chola architecture and is known for its massive monolithic granite dome and intricate sculptures.\r\n\r\nKanyakumari: India's southernmost tip, Kanyakumari, offers breathtaking views of the confluence of the Arabian Sea, Bay of Bengal, and Indian Ocean. The Vivekananda Rock Memorial and Thiruvalluvar Statue are prominent landmarks here. The town is also famous for its stunning sunsets and the tranquil atmosphere of the Vivekananda Kendra Meditation Center.\r\n\r\nTamil Nadu's diverse attractions encompass ancient temples, natural beauty, and vibrant culture, offering a rich and immersive experience for travelers exploring this southern state of India.",
                    DestinationPrice = 45000.00m,
                    DestinationImageUrl = "/images/marina.jpg",
                    DestinationVideoUrl = "/videos/che_dest.mp4",
                    DestLocationId = 4,
                    HotelChainId = 4
                });

            modelBuilder.Entity<Destination>().HasData
                (new Destination
                {
                    DestinationId = 5,
                    DestinationName = "Kolkata",
                    DestinationState = "West Bengal",
                    DestinationDescription = "The Victoria Memorial, a magnificent white marble monument, stands as a symbol of Kolkata's rich history and architectural splendor.",
                    DestinationDetailedDescription = "Kolkata: The capital of West Bengal, Kolkata, is a vibrant city steeped in history and culture. Visitors can explore the historic Victoria Memorial, a magnificent marble edifice, and the iconic Howrah Bridge, one of India's busiest and most recognizable landmarks. Kolkata is also known for its literary heritage, with attractions like the Marble Palace, Indian Museum, and the Tagore House, the former residence of Nobel laureate Rabindranath Tagore.\r\n\r\nSundarbans Mangrove Forest: The Sundarbans, a UNESCO World Heritage Site, is the largest mangrove forest in the world and a vital ecosystem for Bengal tigers, saltwater crocodiles, and various bird species. Tourists can take boat safaris through the dense mangrove waterways to catch a glimpse of these magnificent creatures in their natural habitat.\r\n\r\nDarjeeling: Nestled in the Himalayan foothills, Darjeeling is a picturesque hill station famous for its tea plantations and stunning mountain views, including the snow-capped peaks of Kanchenjunga. The Darjeeling Himalayan Railway, also known as the \"Toy Train,\" is a UNESCO World Heritage Site and a charming way to explore the town's scenic beauty.\r\n\r\nKalimpong: A serene hill station situated at a higher altitude than Darjeeling, Kalimpong is known for its lush forests, beautiful nurseries, and panoramic views of the Himalayas. The Durpin Monastery and Zang Dhok Palri Phodang Monastery are cultural landmarks worth visiting.\r\n\r\nDigha and Mandarmani: These coastal towns along the Bay of Bengal offer sandy beaches and tranquil seaside escapes. Digha, known as the \"Brighton of the East,\" is a popular beach destination, while Mandarmani is known for its long stretches of pristine beach and water sports activities.\r\n\r\nMurshidabad: This historic town on the banks of the Bhagirathi River was once the capital of the Bengal Nawabs. Visitors can explore the Hazarduari Palace, known for its thousand doors, and the Nizamat Imambara. The town is rich in history and architectural heritage.\r\n\r\nBishnupur: Known for its terracotta temples, Bishnupur is a town steeped in the culture of the Malla dynasty. The Jor Mandir, Rasmancha, and Madan Mohan Temple are prime examples of the intricate terracotta work that adorns these ancient structures.\r\n\r\nJaldapara National Park: Located in the Alipurduar district, this national park is home to a diverse range of wildlife, including the Indian rhinoceros and Bengal tigers. Safari tours offer a chance to observe these majestic creatures in their natural habitat.\r\n\r\nWest Bengal's tourism offerings range from bustling cities rich in history to serene hill stations and natural wonders, providing a diverse and enriching experience for travelers exploring this eastern Indian state.",
                    DestinationPrice = 35000.00m,
                    DestinationImageUrl = "/images/vitoria.jpg",
                    DestinationVideoUrl = "/videos/kol_dest.mp4",
                    DestLocationId = 5,
                    HotelChainId = 5
                });

            modelBuilder.Entity<Destination>().HasData
                (new Destination
                {
                    DestinationId = 7,
                    DestinationName = "Maldives",
                    DestinationState = "Maldives",
                    DestinationDescription = "The Maldives: Where turquoise waters and white sandy beaches create a symphony of serenity.",
                    DestinationDetailedDescription = "Male: The capital city of the Maldives, Male, is a bustling urban center that offers a glimpse into the local way of life. While it may be small, it's packed with attractions like the historic Hukuru Miskiy (Friday Mosque), the ornate Islamic Centre with its golden dome, and the bustling local fish market. Visitors can also explore the colorful streets, enjoy the seafront, and experience the vibrant culture of the Maldivian people.\r\n\r\nAri Atoll: The Ari Atoll is a paradise for divers and snorkelers, boasting some of the Maldives' most incredible underwater experiences. The clear, turquoise waters are home to vibrant coral reefs teeming with marine life, including sharks, manta rays, and colorful fish. Resorts in the Ari Atoll offer luxury accommodations and easy access to world-class diving and water sports.\r\n\r\nBaa Atoll: As a UNESCO Biosphere Reserve, Baa Atoll is known for its rich biodiversity and conservation efforts. It's a prime spot for snorkeling and diving, especially at Hanifaru Bay, where large gatherings of manta rays and whale sharks are a common sight during the appropriate season. The area also features luxury resorts and pristine beaches.\r\n\r\nMaldives Underwater Restaurant: The Maldives is renowned for its unique underwater restaurants, such as Ithaa Undersea Restaurant at Conrad Maldives Rangali Island. Dining in a transparent acrylic structure beneath the sea offers an unparalleled opportunity to savor delicious cuisine while observing the mesmerizing marine life that surrounds you.\r\n\r\nAddu Atoll: Located in the southernmost part of the Maldives, Addu Atoll is known for its unique geography and cultural attractions. Visitors can explore the historic British Loyalty Shipwreck, ride bicycles around the interconnected islands, and discover remnants of the World War II era. Addu Atoll also offers excellent diving and water sports opportunities.\r\n\r\nVaadhoo Island: This remote island is famous for its captivating natural phenomenon known as \"bioluminescent beaches.\" At night, the water's edge glows with a blue luminescence, creating a magical and surreal atmosphere that is truly unforgettable.\r\n\r\nMaafushi Island: Maafushi is one of the few inhabited islands in the Maldives that allows budget-conscious travelers to experience the beauty of the archipelago without the price tag of a private resort. Visitors can enjoy water sports, snorkeling, and excursions to nearby deserted islands.\r\n\r\nHulhumale: This reclaimed island near the Male International Airport offers a convenient stopover for travelers arriving or departing from the Maldives. It boasts a beautiful artificial beach, vibrant local markets, and a relaxing atmosphere.\r\n\r\nThe Maldives, with its pristine beaches, crystal-clear waters, and abundant marine life, is a tropical paradise that caters to a wide range of travelers, from those seeking luxury and relaxation to adventure enthusiasts and cultural explorers. Each of these tourist spots in the Maldives offers a unique experience in this idyllic island nation.",
                    DestinationPrice = 110000.00m,
                    DestinationImageUrl = "/images/maldives.jpeg",
                    DestinationVideoUrl = "/videos/maldives_dest.mp4",
                    DestLocationId = 1,
                    HotelChainId = 7
                });
        }
    }
}
