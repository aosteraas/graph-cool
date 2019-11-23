//
//  ContentView.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 19/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI
import Apollo
import Network

struct ContentView: View {
    private let bagelPink = UIColor(red: 0.95805620825129523, green: 0.28210045499878755, blue: 1, alpha: 1)
    
    init() {
        let navAppearance = UINavigationBar.appearance()
        navAppearance.barTintColor = bagelPink
        navAppearance.titleTextAttributes = [
            .font: UIFont(name: "Chalkboard SE", size: 20)!,
            .foregroundColor: UIColor.white
        ]
    }
    
     func doThing() {
        
//           apollo.fetch(query: GetImagesQuery()) { result in
//               switch result {
//               case .success(let graphQLResult):
//                let things:[GetImagesQuery.Data.GetImage?]? = graphQLResult.data?.getImages
//                   print(things)
//               case .failure(let error):
//                 NSLog("Error while fetching query: \(error.localizedDescription)")
//               }
//               guard let data = try? result.get().data else {return}
//               print(data)
//               
//           }
       }
    
//    let data = controller.something
    var body: some View {
        NavigationView {
            
//            HStack {
                Text("Hello, World!")
                    .font(.title)
                
//            }
            
            .navigationBarTitle("BagelGram", displayMode: .inline)
            
        
        }
        
        //.edgesIgnoringSafeArea(.top)
        
    }
    
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}

